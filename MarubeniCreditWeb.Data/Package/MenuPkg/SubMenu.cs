using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.MenuPkg
{
    public class SubMenu
    {
        const int strMaxTitulo = 10;
        const int strMaxSubTitulo = 20;
        const int strMax = 120;
        [StringLength(maximumLength: strMaxTitulo)]
        public string tituloMenu { get; set; }
        [StringLength(maximumLength: strMaxSubTitulo)]
        public string tituloSubMenu { get; set; }
        public string url { get; set; }
        public string urlAction { get; set; }
        public string urlController { get; set; }
        public string imagen { get; set; }
        public int idTipoUrl { get; set; }
        public int idMenu { get; set; }
        public int idTipoMenu { get; set; }
    }
}
