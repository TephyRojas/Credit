using System.ComponentModel.DataAnnotations;
using System.Web;
using MarubeniCreditWeb.Data.Package.ValidationAttributes;


namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class FormTrabNos
    {
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombreTrabNos { get; set; }
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Apellido es demasiado largo")]
        [Required]
        public string apellidoTrabNos { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telMovilTrabNos { get; set; }

        [StringLength(60, ErrorMessage = "El Email es demasiado largo")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailTrabNos { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(50, ErrorMessage = "Nombre región es demasiado largo")]
        [Required]
        public string regionTrabNos { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(30, ErrorMessage = "Nombre comuna es demasiado largo")]
        [Required]
        public string comunaTrabNos { get; set; }

        [StringLength(500, ErrorMessage = "El mensaje es demasiado largo")]
        public string mensajeTrabNos { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Archivo es Obligatorio")]
        [ExtensionArchivo(new[] { "image/jpeg", "image/png", "application/pdf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" })] //MIME Type for HTML
        public HttpPostedFileBase fileTrabNos { get; set; }
    }
}
