using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class Certificado
    {
        const int strMax = 10;
        [StringLength(maximumLength: strMax)]
        public string certificado { get; set; }
        public string emailDeriv1 { get; set; }
        public string emailDeriv2 { get; set; }
        public int orden { get; set; }
    }
}
