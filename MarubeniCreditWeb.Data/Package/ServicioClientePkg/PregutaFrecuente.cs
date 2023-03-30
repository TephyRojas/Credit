using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class PregutaFrecuente
    {
        const int strMax = 500;
        [StringLength(maximumLength: strMax)]
        public string pregunta { get; set; }
        [StringLength(maximumLength: strMax)]
        public string respuesta { get; set; }
        public string respuesta2 { get; set; }
        public string urlTexto { get; set; }
        public string url { get; set; }
        public string urlAction { get; set; }
        public string urlController { get; set; }
        public int idTipoUrl { get; set; }
        public int orden { get; set; }
    }
}
