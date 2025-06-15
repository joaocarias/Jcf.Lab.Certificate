using System;

namespace Jcf.Lab.CertificatePfx.AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var certificate = new CertificatePfx("D:/rootCert.pfx", string.Empty);
            certificate.PrintProperts();
            if(!certificate.IsValid()){
                certificate.DeleteFile();
            }            
        }
    }
}
