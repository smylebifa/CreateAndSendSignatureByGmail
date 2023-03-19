using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptLab1WebAppMVC.Services
{
    public class EmailService
    {
        public static int numberOfMessage = 0;

        public static Dictionary<string, string> GetMessage(string receiverDirPath, string emailDir, string keysDir)
        {
            Pop3Client client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);

            byte[] receiverEmail = System.IO.File.ReadAllBytes(receiverDirPath + emailDir + "Email.txt");
            byte[] applicationPassword = System.IO.File.ReadAllBytes(receiverDirPath + emailDir + "ApplicationPassword.txt");

            client.Authenticate(Encoding.Default.GetString(receiverEmail), Encoding.Default.GetString(applicationPassword));

            int messageCount = client.GetMessageCount() - numberOfMessage;
            string subject = client.GetMessage(messageCount).Headers.Subject;
            string date = client.GetMessage(messageCount).Headers.DateSent.ToString("yyyy-MM-dd");
            string senderEmail = client.GetMessage(messageCount).Headers.From.Address;

            var attachments = client.GetMessage(messageCount).FindAllAttachments();
            foreach (var attachment in attachments)
            {
                attachment.Save(new System.IO.FileInfo(System.IO.Path.Combine(receiverDirPath + keysDir, attachment.FileName)));
            }

            var HtmlMessage = client.GetMessage(messageCount).FindAllTextVersions();
            string textMessage = "";

            if (HtmlMessage.FirstOrDefault() != null)
            {
                textMessage = HtmlMessage[0].GetBodyAsText();
                byte[] msg = Encoding.Default.GetBytes(textMessage);
                System.IO.File.WriteAllBytes(receiverDirPath + keysDir + "Data.txt", msg);
            }

            Dictionary<string, string> savedInfo = new Dictionary<string, string>();
            savedInfo.Add("subject", subject);
            savedInfo.Add("date", date);
            savedInfo.Add("email", senderEmail);
            savedInfo.Add("textMessage", textMessage);

            return savedInfo;
        }
    }
}
