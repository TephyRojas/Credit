using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class Carrete
    {
        const int strMax = 120;
        [StringLength(maximumLength: strMax)]
        public string texto { get; set; }
        public string btnTexto { get; set; }
        public string btnUrl { get; set; }
        public string imgUrl { get; set; }
    }
}
