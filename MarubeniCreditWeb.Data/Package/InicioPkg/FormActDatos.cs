using System.ComponentModel.DataAnnotations;


namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class FormActDatos
    {
        [RegularExpression("(^[0-9-.Kk]+$)", ErrorMessage = "Formato Rut Incorrecto")]
        [Required]
        public string rutActDatos { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-ZñÑÀ-ÿ ]+$", ErrorMessage = "Solo letras")]
        [StringLength(60, ErrorMessage = "El Nombre es demasiado largo")]
        [Required]
        public string nombreActDatos { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(100, ErrorMessage = "La dirección es demasiado larga")]
        [Required]
        public string direccionActDatos { get; set; }

        [RegularExpressionAttribute(@"^[a-zA-Z0-9ñÑÀ-ÿ. ]+$", ErrorMessage = "Solo letras y números")]
        [StringLength(30, ErrorMessage = "Nombre comuna es demasiado largo")]
        [Required]
        public string comunaActDatos { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telMovilActDatos { get; set; }

        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es obligatorio")]
        [StringLength(17, ErrorMessage = "El número es demasiado largo")]
        public string telefonoActDatos { get; set; }

    }
}
