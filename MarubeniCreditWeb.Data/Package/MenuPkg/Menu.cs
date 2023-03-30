using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.MenuPkg
{
    public class Menu
    {
        const int strMaxTitulo = 10;
        const int strMaxSubTitulo = 20;
        const int strMax = 120;
        [StringLength(maximumLength: strMaxTitulo)]
        public string titulo { get; set; }
        [StringLength(maximumLength: strMaxSubTitulo)]
        public string subtitulo { get; set; }
        [StringLength(maximumLength: strMax)]
        public string url { get; set; }
        public string urlAction { get; set; }
        public string urlController { get; set; }
        public string imagen { get; set; }
        public int idTipoUrl { get; set; }
        public int idMenu { get; set; }
        public int idTipoMenu { get; set; }
        public int orden { get; set; }
    }
}
