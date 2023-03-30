using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Dtos;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Helper
{
    public class AddressMail
    {
        public string email { get; set; }

        public List<AddressMail> GetEmailDeriv(int formulario, string parametro)
        {

            List<AddressMail> lstAddressMail = new List<AddressMail>();
            List<EmailDeriv> lstEmailDeriv = new List<EmailDeriv>();
            ServicioClienteService servicioClienteService = new ServicioClienteService();


            lstEmailDeriv = servicioClienteService.GetEmail(formulario, parametro);

            foreach (var item in lstEmailDeriv)
            {
                if (!string.IsNullOrEmpty(item.emailDeriv))
                {
                    AddressMail addressMail = new AddressMail();
                    addressMail.email = item.emailDeriv;
                    lstAddressMail.Add(addressMail);
                }

            }

            return lstAddressMail;
        }
    }
}