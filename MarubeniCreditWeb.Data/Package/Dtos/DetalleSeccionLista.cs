using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.Dtos
{
    public class DetalleSeccionLista
    {
        const int strMax = 120;
        [StringLength(maximumLength: strMax)]
        public string titulo { get; set; }
        public List<TextoSeccion> lstTexto { get; set; }
        public string descripcion { get; set; }
        public string btnTexto { get; set; }
        public string url { get; set; }
        public string urlAction { get; set; }
        public string urlController { get; set; }
        public string imagen { get; set; }
        public string icono { get; set; }
        public int idTipoUrl { get; set; }
        public int idSeccion { get; set; }
    }
}
