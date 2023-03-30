using System.ComponentModel.DataAnnotations;
using System.Web;
using MarubeniCreditWeb.Data.Package.ValidationAttributes;
namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class FormPortCertificado
    {
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(60, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombrePortCert { get; set; }

        //[StringLength(40, ErrorMessage = "El Apellido es demasiado largo")]
        //[Required]
        //public string apellidoPortCert { get; set; }

        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        [Required]
        public string rutPortCert { get; set; }

        [StringLength(60, ErrorMessage = "El Email es demasiado largo")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailPortCert { get; set; }

         [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(50, ErrorMessage = "Nombre región es demasiado largo")]
        [Required]
        public string regionPortCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(30, ErrorMessage = "Nombre comuna es demasiado largo")]
        [Required]
        public string comunaPortCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(100, ErrorMessage = "La dirección es demasiado larga")]
        [Required]
        public string direccionPortCert { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telMovilPortCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(60, ErrorMessage = "El Nombre es demasiado largo")]
        public string nombreRepPortCert { get; set; }

        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        public string rutRepPortCert { get; set; }

        //[RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(80, ErrorMessage = "Certificado es demasiado largo")]
        [Required]
        public string certificadoPortCert { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Archivo es Obligatorio")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase file1PortCert { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ,. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(500, ErrorMessage = "El texto es demasiado largo")]
        public string prodServPortCert { get; set; }
        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ,. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(300, ErrorMessage = "El texto es demasiado largo")]
        public string nroCredPortCert { get; set; }
        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ,. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(300, ErrorMessage = "El texto es demasiado largo")]
        public string patentePortCert { get; set; }

        [StringLength(60, ErrorMessage = "El texto es demasiado largo")]
        public string recepCorreoPortCert { get; set; }

        [StringLength(60, ErrorMessage = "El texto es demasiado largo")]
        public string recepRetiroPortCert { get; set; }
    }
}
