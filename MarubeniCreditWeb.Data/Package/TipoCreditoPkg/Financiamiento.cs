using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.TipoCreditoPkg
{
    public class Financiamiento
    {
        const int strMax = 120;
        [StringLength(maximumLength: 20)]
        public string titulo { get; set; }
        [StringLength(maximumLength: 120)]
        public string texto { get; set; }
        public string btnTexto { get; set; }
        public string btnUrl { get; set; }
        public string imgUrl { get; set; }
    }
}
