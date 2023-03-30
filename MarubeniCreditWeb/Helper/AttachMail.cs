using System.Web;

namespace MarubeniCreditWeb.Helper
{
    public class AttachMail
    {
        public string nombre { get; set; }
        public HttpPostedFileBase archivo { get; set; }
        public string extension { get; set; }
    }
}