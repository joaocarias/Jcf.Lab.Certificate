namespace Jcf.Lab.CertificatePfx.Lib.src
{
    public class CertificatePfx
    {
        private string _certificatePfx;

        public CertificatePfx()
        {
            _certificatePfx = string.Empty;
        }

        public CertificatePfx(string certificatePfx)
        {
            _certificatePfx = certificatePfx;
        }

        override
        public string ToString()
        {
            return $"cetificatePfx: {_certificatePfx}";
        }
    }
}
