using System;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Chronus.Library
{
    public class Certificado
    {
        public X509Certificate2 CriarCertificado(byte[] data)
        {
            return new X509Certificate2(data);
        }

        public X509Certificate2 SelecionarCertificado(string serial)
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            var collection = (X509Certificate2Collection)store.Certificates;
            store.Close();

            foreach (X509Certificate2 certificado in collection)
                if (certificado.SerialNumber == serial)
                    return certificado;

            return SelecionarCertificado();
        }

        public X509Certificate2 SelecionarCertificado()
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            var collection = store.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            var certificados = X509Certificate2UI.SelectFromCollection(collection, "Certificados digitais válidos disponíveis ", "Selecione um certificado digital", X509SelectionFlag.SingleSelection);

            store.Close();
            return certificados.Count > 0 ? certificados[0] : null;
        }

        public X509Certificate2 SelecionarCertificado(IntPtr handle)
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            var collection = store.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, false);
            var certificados = X509Certificate2UI.SelectFromCollection(collection, "Certificados digitais válidos disponíveis ", "Selecione um certificado digital", X509SelectionFlag.SingleSelection, handle);

            store.Close();
            return certificados.Count > 0 ? certificados[0] : null;
        }

        private RSACryptoServiceProvider GetRSACryptoServiceProvider(X509Certificate2 certificado, string senha, ref string mensagem)
        {
            RSACryptoServiceProvider rsaKey = null;

            if (!string.IsNullOrWhiteSpace(senha))
            {
                SecureString senhaSecure = new SecureString();
                foreach (char c in senha.ToCharArray())
                    senhaSecure.AppendChar(c);

                RSACryptoServiceProvider rsaKeyBase = new RSACryptoServiceProvider();
                try
                {
                    rsaKeyBase = (RSACryptoServiceProvider)certificado.PrivateKey;
                }
                catch (Exception)
                {
                    mensagem = "E_acessar_chave_certificado";
                }

                CspParameters cspParams = new CspParameters();
                cspParams.ProviderName = rsaKeyBase.CspKeyContainerInfo.ProviderName;
                cspParams.ProviderType = rsaKeyBase.CspKeyContainerInfo.ProviderType;
                cspParams.KeyNumber = rsaKeyBase.CspKeyContainerInfo.KeyNumber == KeyNumber.Exchange ? 1 : 2;
                cspParams.KeyContainerName = rsaKeyBase.CspKeyContainerInfo.KeyContainerName;
                cspParams.KeyPassword = senhaSecure;
                cspParams.Flags = CspProviderFlags.NoPrompt | CspProviderFlags.UseDefaultKeyContainer;

                try
                {
                    rsaKey = new RSACryptoServiceProvider(cspParams);
                }
                catch (Exception E)
                {
                    mensagem = "E_SenhaCert_Incorreta" + E.Message;
                }
            }
            else
                rsaKey = new RSACryptoServiceProvider();

            return rsaKey;
        }
    }
}
