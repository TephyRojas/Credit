using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarubeniCreditWeb.Data.Package.ValidationAttributes
{
    public class ExtensionArchivoAttribute : ValidationAttribute
    {
        private readonly string[] tiposValidos;

        public ExtensionArchivoAttribute(string[] tiposValidos)
        {
            this.tiposValidos = tiposValidos;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var formfile = value as HttpPostedFileBase;

            if (formfile != null)
            {
                if (!tiposValidos.Contains(formfile.ContentType))
                {
                    return new ValidationResult($"Los tipos validos son { string.Join(",", tiposValidos)}");
                }
            }

            return ValidationResult.Success;
        }
    }
}
