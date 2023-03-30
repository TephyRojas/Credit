using System.ComponentModel.DataAnnotations;
using System.Web;
using MarubeniCreditWeb.Data.Package.ValidationAttributes;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class FormCertificadoFile
    {
        public string certificadoCert { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Archivo es Obligatorio")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file1Cert { get; set; }
        public string file1CertRuta { get; set; }
        public string file1CertTipo { get; set; }
    }
}
