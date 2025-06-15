using System;
using System.Security.Cryptography.X509Certificates;

namespace Jcf.Lab.CertificatePfx.AppConsole
{
    public class CertificatePfx
    {
        private X509Certificate2 _certificate;
        private string _path;
        private string _password;

        public CertificatePfx()
        {
            _path = string.Empty;
            _password = string.Empty;
            _certificate = new X509Certificate2();
        }

        public CertificatePfx(string certificatePfx, string password)
        {
            _path = certificatePfx;
            _password = password;

            _certificate = new X509Certificate2(_path, _password);
        }

        override
        public string ToString()
        {
            return $"cetificatePfx: {_path} | password: {_password}";
        }

        public void PrintProperts()
        {
            Console.WriteLine($"Emitido para: {_certificate.Subject}");
            Console.WriteLine($"Emitido por: {_certificate.Issuer}");
            Console.WriteLine($"Válido de: {_certificate.NotBefore}");
            Console.WriteLine($"Válido até: {_certificate.NotAfter}");
                      
            if (IsValid())
            {
                Console.WriteLine("✔️ O certificado é válido.");
            }
            else
            {
                Console.WriteLine("❌ O certificado NÃO é válido.");
            }
        }

        public bool IsValid()
        {
            return _certificate.Verify() && DateTime.Now >= _certificate.NotBefore && DateTime.Now <= _certificate.NotAfter;
        }

        public void DeleteFile()
        {
            try
            {
                System.IO.File.Delete(_path);   
                _certificate = new X509Certificate2();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
