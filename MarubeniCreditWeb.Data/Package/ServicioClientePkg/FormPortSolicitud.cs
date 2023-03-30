using System.ComponentModel.DataAnnotations;
using System.Web;
using MarubeniCreditWeb.Data.Package.ValidationAttributes;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class FormPortSolicitud
    {
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(60, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombrePortSoli { get; set; }

        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        [Required]
        public string rutPortSoli { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telefonoPortSoli { get; set; }

        [StringLength(60, ErrorMessage = "El Email es demasiado largo")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailPortSoli { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Imágenes del carnet son obligatorias")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file1PortSoli { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Imágenes del carnet son obligatorias")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file2PortSoli { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Formulario es obligatorio")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file3PortSoli { get; set; }

    }
}
