using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class FormContacto
    {
        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombreCont { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(40, ErrorMessage = "El Apellido es demasiado largo")]
        [Required]
        public string apellidoCont { get; set; }

        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        [Required]
        public string rutCont { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telefonoCont { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(50, ErrorMessage = "Nombre región es demasiado largo")]
        [Required]
        public string regionCont { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(30, ErrorMessage = "Nombre comuna es demasiado largo")]
        [Required]
        public string comunaCont { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(100, ErrorMessage = "La dirección es demasiado larga")]
        [Required]
        public string direccionCont { get; set; }

        [StringLength(60, ErrorMessage = "El Email es demasiado largo")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailCont { get; set; }

        [StringLength(500, ErrorMessage = "El mensaje es demasiado largo")]
        public string mensajeCont { get; set; }

        //[RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(100, ErrorMessage = "El motivo consulta es demasiado largo")]
        public string tipoConsultaCont { get; set; }
    }
}
