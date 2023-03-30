using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.ArchivosPkg
{
    public class ArchivoDescargable
    {
        const int strMax = 120;
        public int codigo { get; set; }
        [StringLength(maximumLength: strMax)]
        public string nombre { get; set; }
        public string extension { get; set; }
    }
}

