using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class PagoOnline
    {
        [StringLength(maximumLength: 30)]
        public string titulo { get; set; }
        [StringLength(maximumLength: 300)]
        public string texto { get; set; }
        public string btnTexto { get; set; }
        public string btnUrl { get; set; }
    }
}
