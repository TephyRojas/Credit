using System.ComponentModel.DataAnnotations;
using System.Web;
using MarubeniCreditWeb.Data.Package.ValidationAttributes;
namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class FormCertificado
    {
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombreCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Apellido es demasiado largo")]
        [Required]
        public string apellidoCert { get; set; }

        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        [Required]
        public string rutCert { get; set; }

        [StringLength(60, ErrorMessage = "El Email es demasiado largo")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(50, ErrorMessage = "Nombre región es demasiado largo")]
        [Required]
        public string regionCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(30, ErrorMessage = "Nombre comuna es demasiado largo")]
        [Required]
        public string comunaCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(100, ErrorMessage = "La dirección es demasiado larga")]
        [Required]
        public string direccionCert { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telMovilCert { get; set; }

        [StringLength(30, ErrorMessage = "La operación es demasiado larga")]
        [Required]
        public string operacionCert { get; set; }

        [StringLength(30, ErrorMessage = "La patente es demasiado larga")]
        [Required]
        public string patenteCert { get; set; }

        [StringLength(500, ErrorMessage = "El mensaje es demasiado largo")]
        public string mensajeCert { get; set; }

        [StringLength(80, ErrorMessage = "Certificado es demasiado largo")]
        [Required]
        public string certificadoCert { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Archivo es Obligatorio")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file2Cert { get; set; }

        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file1Cert { get; set; }


    }
}
