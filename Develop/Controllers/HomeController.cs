using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mail;
using System.Net;
using OpenPop.Pop3;
using System.Text;
using CryptLab1WebAppMVC.Services;

namespace CryptLab1WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Microsoft.AspNetCore.Hosting.IWebHostEnvironment _appEnvironment;
        public static DigitalSignature digitalSignature;
        public string receiverDirPath;
        public string senderDirPath;
        public string emailDir;
        public string keysDir;

        public HomeController(ILogger<HomeController> logger, Microsoft.AspNetCore.Hosting.IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            digitalSignature = new DigitalSignature();
            _appEnvironment = appEnvironment;
            senderDirPath = _appEnvironment.WebRootPath + "/FilesOfSender/";
            receiverDirPath = _appEnvironment.WebRootPath + "/FilesOfReceiver/";
            emailDir = "EmailAndPassword/";
            keysDir = "KeysAndSignature/";
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult CreateKeys()
        {
            if (!System.IO.File.Exists(senderDirPath + keysDir + "PrivateKey.db"))
            {
                byte[] private_key, public_key;
                var dsa = digitalSignature.CreateECDKey(out private_key, out public_key);
                System.IO.File.WriteAllBytes(senderDirPath + keysDir + "PrivateKey.db", private_key);
                System.IO.File.WriteAllBytes(senderDirPath + keysDir + "PublicKey.db", public_key);
            }

            return RedirectToAction("CreateSignaturePage", "Home", new { status = "keysAreCreated" });
        }

        public IActionResult CreateSignaturePage(string status = "", string text = "")
        {
            if (status == "keysAreCreated")
            {
                ViewBag.ActionType = status;
            }

            else if (status == "signatureIsCreated")
            {
                ViewBag.ActionType = status;
                ViewBag.Text = text;
            }

            return View();
        }


        [HttpPost]
        public IActionResult CreateSignatureForm()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            if (form.ContainsKey("text"))
            {
                string text = form["text"];

                // Если подписи нет, создаем ее
                if (!System.IO.File.Exists(senderDirPath + keysDir + "Signature.db"))
                {
                    // Если закрытого ключа нет, создаем его
                    if (!System.IO.File.Exists(senderDirPath + keysDir + "PrivateKey.db"))
                    {
                        byte[] private_key, public_key;
                        var dsa = digitalSignature.CreateECDKey(out private_key, out public_key);
                        System.IO.File.WriteAllBytes(senderDirPath + keysDir + "PrivateKey.db", private_key);
                        System.IO.File.WriteAllBytes(senderDirPath + keysDir + "PublicKey.db", public_key);
                    }

                    byte[] msg = Encoding.Default.GetBytes(text);

                    var privatekey = System.IO.File.ReadAllBytes(senderDirPath + keysDir + "PrivateKey.db");
                    var signature = digitalSignature.GetSignature(privatekey, msg);
                    System.IO.File.WriteAllBytes(senderDirPath + keysDir + "Signature.db", signature);
                    System.IO.File.WriteAllBytes(senderDirPath + keysDir + "Data.txt", msg);
                }
                
                return RedirectToAction("CreateSignaturePage", "Home", new { status = "signatureIsCreated", text });
            }

            else
            {
                return RedirectToAction("CreateSignaturePage", "Home", new { status = "error" });
            }

        }


        [HttpGet("/send_email_message")]
        public IActionResult SendMessagePage(string statusOfAccess = "", string statusOfSend = "", string senderEmail = "", string applicationPassword = "", string receiverEmail = "")
        {
            ViewBag.StatusAccess = statusOfAccess;
            ViewBag.StatusOfSend = statusOfSend;
            ViewBag.SenderEmail = senderEmail;
            ViewBag.ApplicationPassword = applicationPassword;
            ViewBag.ReceiverEmail = receiverEmail;

            return View();
        }


        public bool AccessToEmailAllowed(string typeUserPath, string email, string applicationPassword)
        {
            try
            {
                Pop3Client client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(email, applicationPassword);

                byte[] emailBytes = Encoding.Default.GetBytes(email);
                byte[] applicationPasswordBytes = Encoding.Default.GetBytes(applicationPassword);
                
                System.IO.File.WriteAllBytes(typeUserPath + emailDir + "Email.txt", emailBytes);
                System.IO.File.WriteAllBytes(typeUserPath + emailDir + "ApplicationPassword.txt", applicationPasswordBytes);

                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        public IActionResult GetAccessToEmailForSend()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            string senderEmail = form["senderEmail"];
            string applicationPassword = form["applicationPassword"];

            if (AccessToEmailAllowed(senderDirPath, senderEmail, applicationPassword))
                return RedirectToAction("SendMessagePage", "Home", new { statusOfAccess = "accessAllowed", senderEmail, applicationPassword });
            else
                return RedirectToAction("SendMessagePage", "Home", new { statusOfAccess = "accessDenied", senderEmail, applicationPassword });
        }



        [HttpPost]
        public IActionResult SendingEmailMessageWithSignature()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            string senderEmail = form["senderEmail"];
            string applicationPassword = form["applicationPassword"];

            string receiverEmail;
            string Subject = "Verification of digital signature";

            if (System.IO.File.Exists(senderDirPath + keysDir + "Data.txt"))
            {
                if (form.ContainsKey("receiverEmail"))
                {
                    receiverEmail = form["receiverEmail"];

                    // Отправка по почте
                    MailAddress from = new MailAddress(senderEmail);
                    MailAddress to = new MailAddress(receiverEmail);

                    MailMessage mailMessage = new MailMessage(from, to);
                    mailMessage.Subject = Subject;
                    
                    byte[] message = System.IO.File.ReadAllBytes(senderDirPath + keysDir + "Data.txt");
                    Encoding.Default.GetString(message);
                    mailMessage.Body = Encoding.Default.GetString(message);

                    // Вложения к письму - публичный ключ и подпись
                    mailMessage.Attachments.Add(new Attachment(senderDirPath + keysDir + "PublicKey.db"));
                    mailMessage.Attachments.Add(new Attachment(senderDirPath + keysDir + "Signature.db"));

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(senderEmail, applicationPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mailMessage);

                    ViewBag.TextMessage = "";
                    ViewBag.Receiver = "";

                    return RedirectToAction("SendMessagePage", "Home", new { statusOfAccess = "accessAllowed", statusOfSend = "messageWasSent", senderEmail, applicationPassword, receiverEmail });
                }

                else
                {
                    return RedirectToAction("SendMessagePage", "Home", new { statusOfAccess = "accessAllowed", statusOfSend = "error", senderEmail, applicationPassword });
                }
            }

            else
            {
                return RedirectToAction("SendMessagePage", "Home", new { statusOfAccess = "accessAllowed", statusOfSend = "errorWithMessage", senderEmail, applicationPassword });
            }
        }

        [HttpGet("/get_email_message")]
        public IActionResult GetMessagePage(string statusOfAccess = "", string statusOfCheckSignature = "", string statusOfChangingMessage = "", string receiverEmail = "", string applicationPassword = "")
        {
            ViewBag.ReceiverEmail = receiverEmail;
            ViewBag.ApplicationPassword = applicationPassword;
            ViewBag.StatusAccess = statusOfAccess;
            ViewBag.StatusOfCheckSignature = statusOfCheckSignature;

            if (statusOfChangingMessage == "next")
            {
                if (EmailService.numberOfMessage > 3)
                    EmailService.numberOfMessage = 0;
                else
                    EmailService.numberOfMessage++;

                ViewBag.StatusAccess = "accessAllowed";
                ViewBag.StatusOfChangingMessage = statusOfChangingMessage;
            }

            else if (statusOfChangingMessage == "prev")
            {
                if (EmailService.numberOfMessage < 1)
                    EmailService.numberOfMessage = 4;
                else
                    EmailService.numberOfMessage--;

                ViewBag.StatusAccess = "accessAllowed";
                ViewBag.StatusOfChangingMessage = statusOfChangingMessage;
            }

            // Функция GetMessage читатет сообщение и сохраняет текст сообщения и вложения (откртый ключ и подпись) в каталоге своего приложения
            Dictionary<string, string> savedInfo = EmailService.GetMessage(receiverDirPath, emailDir, keysDir);

            ViewBag.Subject = savedInfo["subject"];
            ViewBag.Email = savedInfo["email"];
            ViewBag.Date = savedInfo["date"];
            ViewBag.Message = savedInfo["textMessage"];

            return View();
        }

        [HttpPost]
        public IActionResult GetAccessToEmailForReceive()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            string receiverEmail = form["receiverEmail"];
            string applicationPassword = form["applicationPassword"];

            if (AccessToEmailAllowed(receiverDirPath, receiverEmail, applicationPassword))
                return RedirectToAction("GetMessagePage", "Home", new { statusOfAccess = "accessAllowed", receiverEmail, applicationPassword });
            else
                return RedirectToAction("GetMessagePage", "Home", new { statusOfAccess = "accessDenied", receiverEmail, applicationPassword });
        }

        [HttpPost]
        public IActionResult CheckSignature()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            string receiverEmail = form["receiverEmail"];
            string applicationPassword = form["applicationPassword"];

            var publickey = System.IO.File.ReadAllBytes(receiverDirPath + keysDir + "PublicKey.db");
            byte[] message = System.IO.File.ReadAllBytes(receiverDirPath + keysDir + "Data.txt");
            byte[] signature = System.IO.File.ReadAllBytes(receiverDirPath + keysDir + "Signature.db");

            if (digitalSignature.VerifyData(publickey, message, signature))
            {
                return RedirectToAction("GetMessagePage", "Home", new { statusOfAccess = "accessAllowed", statusOfCheckSignature = "success", receiverEmail, applicationPassword });
            }

            else
            {
                return RedirectToAction("GetMessagePage", "Home", new { statusOfAccess = "accessAllowed", statusOfCheckSignature = "error", receiverEmail, applicationPassword });
            }
        }
    }
}
