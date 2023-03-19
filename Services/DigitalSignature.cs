using System;
using System.Security.Cryptography;


namespace CryptLab1WebAppMVC
{
    public class DigitalSignature
    {
        static ECDsaCng ecsdKeyVerify;
        static ECDsaCng ecsdKey;

        public DigitalSignature() { }

        public bool VerifyData(byte[] publickey, byte[] message, byte[] signature)
        {
            if (ecsdKeyVerify == null)
            {
                ecsdKeyVerify = new ECDsaCng(CngKey.Import(publickey, CngKeyBlobFormat.EccPublicBlob));
                ecsdKeyVerify.HashAlgorithm = CngAlgorithm.Sha512;
            }
            if (ecsdKeyVerify.VerifyData(message, signature))
                return true;
            else
                return false;
        }

        public byte[] GetSignature(byte[] privatekey, byte[] msg)
        {
            if (ecsdKey == null)
            {
                ecsdKey = new ECDsaCng(CngKey.Import(privatekey, CngKeyBlobFormat.EccPrivateBlob));
                ecsdKey.HashAlgorithm = CngAlgorithm.Sha512;
            }
            byte[] signature = ecsdKey.SignData(msg);
            if (ecsdKey.VerifyData(msg, signature))
                return signature;
            else
                throw new Exception("Data Verify Failed!");
        }

        public ECDsaCng CreateECDKey(out byte[] PrivateKey, out byte[] PublicKey, string KeyName = "Ключшифрования", string keyAlias = "AdminKey")
        {
            var p = new CngKeyCreationParameters
            {
                ExportPolicy = CngExportPolicies.AllowPlaintextExport,
                KeyCreationOptions = CngKeyCreationOptions.OverwriteExistingKey,
                UIPolicy = new CngUIPolicy(CngUIProtectionLevels.ProtectKey, KeyName, null, null, null)
            };
            var key = CngKey.Create(CngAlgorithm.ECDsaP521, keyAlias, p);
            using (ECDsaCng dsa = new ECDsaCng(key))
            {
                dsa.HashAlgorithm = CngAlgorithm.Sha512;
                PublicKey = dsa.Key.Export(CngKeyBlobFormat.EccPublicBlob);
                PrivateKey = dsa.Key.Export(CngKeyBlobFormat.EccPrivateBlob);
                return dsa;
            }
        }

    }
}