using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class SimulaFinanciamiento
    {
        const int strMax = 300;
        [StringLength(maximumLength: strMax)]
        public string texto { get; set; }
        public string btnTexto { get; set; }
        public string btnUrl { get; set; }
        public string imgUrl { get; set; }
    }
}
