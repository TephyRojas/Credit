using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web.Configuration;
using System.Web.Mvc;

namespace MarubeniCreditWeb.Helper
{
    public class Util
    {

        //private Logger logger = LogManager.GetLogger("logSistema");
        //private Logger logger = LogManager.GetLogger("logSistema");
        private const int keysize = 256;

        #region "Webconfig"

        private string sitioKey = WebConfigurationManager.AppSettings["SitioKey"].ToString();
        public string SitioKey { get => sitioKey; set => sitioKey = value; }

        //private string extensiones = ConfigurationManager.AppSettings["ExtensionValidacion"].ToString();

        //public string Extensiones { get => extensiones; set => extensiones = value; }

        #endregion

        public string TimeStamp()
        {
            string Salida = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString();
            return Salida;
        }

        public string FechaATimeStamp(string Fecha)
        {

            if (Fecha.Length > 0)
            {
                string salida = DateTime.Parse(Fecha).Year.ToString() + "-" + DateTime.Parse(Fecha).Month.ToString() + "-" + DateTime.Parse(Fecha).Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString();
                return salida;
            }
            else
            {
                return Fecha;
            }
        }

        public string FechaToIso(string Fecha)
        {

            if (Fecha.Length > 0)
            {
                string mes = ""; string dia = "";
                if (DateTime.Parse(Fecha).Month.ToString().Length == 1)
                {
                    mes = "0" + DateTime.Parse(Fecha).Month.ToString();
                }
                else
                {
                    mes = DateTime.Parse(Fecha).Month.ToString();
                }
                if (DateTime.Parse(Fecha).Day.ToString().Length == 1)
                {
                    dia = "0" + DateTime.Parse(Fecha).Day.ToString();
                }
                else
                {
                    dia = DateTime.Parse(Fecha).Day.ToString();
                }
                string salida = DateTime.Parse(Fecha).Year.ToString() + "-" + mes + "-" + dia;
                return salida;
            }
            else
            {
                return Fecha;
            }
        }

        public string FechaToIsoHour(string Fecha)
        {

            if (Fecha.Length > 0)
            {
                string mes = ""; string dia = "";
                if (DateTime.Parse(Fecha).Month.ToString().Length == 1)
                {
                    mes = "0" + DateTime.Parse(Fecha).Month.ToString();
                }
                else
                {
                    mes = DateTime.Parse(Fecha).Month.ToString();
                }
                if (DateTime.Parse(Fecha).Day.ToString().Length == 1)
                {
                    dia = "0" + DateTime.Parse(Fecha).Day.ToString();
                }
                else
                {
                    dia = DateTime.Parse(Fecha).Day.ToString();
                }
                string salida = DateTime.Parse(Fecha).Year.ToString() + "-" + mes + "-" + dia + ' ' + DateTime.Parse(Fecha).Hour + ":" + DateTime.Parse(Fecha).Minute + ":" + DateTime.Parse(Fecha).Second;
                return salida;
            }
            else
            {
                return Fecha;
            }
        }

        public string FechaToDayMonthYear(string Fecha)
        {

            if (Fecha.Length > 0)
            {
                string mes = ""; string dia = "";
                if (DateTime.Parse(Fecha).Month.ToString().Length == 1)
                {
                    mes = "0" + DateTime.Parse(Fecha).Month.ToString();
                }
                else
                {
                    mes = DateTime.Parse(Fecha).Month.ToString();
                }
                if (DateTime.Parse(Fecha).Day.ToString().Length == 1)
                {
                    dia = "0" + DateTime.Parse(Fecha).Day.ToString();
                }
                else
                {
                    dia = DateTime.Parse(Fecha).Day.ToString();
                }
                string salida = dia + "/" + mes + "/" + DateTime.Parse(Fecha).Year;
                return salida;
            }
            else
            {
                return Fecha;
            }
        }


        public Boolean IsNumeric(string Valor)
        {
            double Num;

            try
            {

                bool isNum = double.TryParse(Valor, out Num);

                if (isNum)
                    return true;
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }

        //public void logSistema(string mensaje, int? idTipo = 0)
        //{
        //    switch (idTipo)
        //    {
        //        case 1: //Info
        //            logger.Info(mensaje);
        //            break;
        //        case 2: //Error
        //            logger.Error(mensaje);
        //            break;
        //        case 0:
        //            logger.Fatal(mensaje);
        //            break;
        //        default:
        //            logger.Fatal(mensaje);
        //            break;
        //    }
        //}

        public jsonReturn RespuestaJson(bool estado, ModelStateDictionary modelState, string errorMessage, string Redirect)
        {
            var respuesta = new jsonReturn();
            List<string> errorControl = new List<string>();
            string error = "";

            foreach (var item in modelState)
            {
                if (item.Value.Errors.Count > 0)
                {
                    error = item.Key.ToString() + "|" + item.Value.Errors[0].ErrorMessage.ToString();
                }
                else
                {
                    error = item.Key.ToString() + "|NOERROR";
                }

                errorControl.Add(error);
            }

            respuesta.errorSumary = modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            respuesta.respuesta = estado;
            respuesta.errorMessage = errorMessage;
            respuesta.errorControl = errorControl;
            respuesta.redirect = Redirect;

            return respuesta;

        }

        public int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }

        public jsonReturn ContrasenasInvalidasJson(bool estado, ModelStateDictionary modelState, string errorMessage, string Redirect)
        {
            var respuesta = new jsonReturn();
            List<string> errorControl = new List<string>();
            string error = "";

            foreach (var item in modelState)
            {
                if (item.Key.ToString() == "clave")
                {
                    error = item.Key.ToString() + "|Las contraseñas no son iguales.";
                    errorControl.Add(error);
                }
                else if (item.Key.ToString() == "repitaClave")
                {
                    error = item.Key.ToString() + "|Las contraseñas no son iguales.";
                    errorControl.Add(error);
                }
                else
                {
                    error = item.Key.ToString() + "|NOERROR";
                    errorControl.Add(error);
                }
            }

            respuesta.errorSumary = modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            respuesta.respuesta = estado;
            respuesta.errorMessage = errorMessage;
            respuesta.errorControl = errorControl;
            respuesta.redirect = Redirect;

            return respuesta;

        }

        public Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public jsonReturn CorreoInvalidoJson(bool estado, ModelStateDictionary modelState, string errorMessage, string Redirect)
        {
            var respuesta = new jsonReturn();
            List<string> errorControl = new List<string>();
            string error = "";

            foreach (var item in modelState)
            {
                if (item.Key.ToString() == "email")
                {
                    error = item.Key.ToString() + "|El correo ingresado es invalido.";
                    errorControl.Add(error);
                }
                else
                {
                    error = item.Key.ToString() + "|NOERROR";
                    errorControl.Add(error);
                }
            }

            respuesta.errorSumary = modelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            respuesta.respuesta = estado;
            respuesta.errorMessage = errorMessage;
            respuesta.errorControl = errorControl;
            respuesta.redirect = Redirect;

            return respuesta;

        }

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función "desencripta" la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted =
            Convert.FromBase64String(_cadenaAdesencriptar);
            //result = 
            System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public bool SendMail(string Subject, string body, List<AddressMail> lstAddressMail, List<AttachMail> lstAttachMail)
        {
            try
            {
                var Mensaje = new MailMessage();
                foreach (var item in lstAddressMail)
                {
                    Mensaje.To.Add(item.email);
                }
                //Mensaje.To.Add(new MailAddress(WebConfigurationManager.AppSettings["MailDestinatario"]));
                Mensaje.From = new MailAddress(WebConfigurationManager.AppSettings["MailRemitente"]);
                //Mensaje.CC.Add(new MailAddress(WebConfigurationManager.AppSettings["MailCC1"]));
                //Mensaje.CC.Add(new MailAddress(WebConfigurationManager.AppSettings["MailCC2"]));
                Mensaje.Subject = Subject;
                Mensaje.Body = body;
                Mensaje.IsBodyHtml = true;
                if (lstAttachMail.Count > 0)
                {
                    foreach (var item in lstAttachMail)
                    {
                        var attachment = new Attachment(item.archivo.InputStream, item.archivo.FileName);
                        Mensaje.Attachments.Add(attachment);
                    }

                }

                using (var smtp = new SmtpClient())
                {

                    smtp.Host = WebConfigurationManager.AppSettings["SMTPHost"];
                    smtp.Port = int.Parse(WebConfigurationManager.AppSettings["SMTPPort"]);
                    smtp.EnableSsl = false;
                    smtp.Send(Mensaje);
                    return true;
                }
            }
            catch (System.Exception ex)
            {

            }
            return false;
        }


        //public  Boolean SendEmailWithOutlook(string mailDirection, string mailSubject, string maiLContent)
        //{
        //    try
        //    {
        //        var oApp = new Microsoft.Office.Interop.Outlook.Application();

        //        Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
        //        var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

        //        System.Threading.Thread.Sleep(1000);

        //        var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

        //        mailItem.Subject = mailSubject;
        //        mailItem.HTMLBody = maiLContent;
        //        mailItem.To = mailDirection;
        //        mailItem.Send();

        //    }
        //    catch (System.Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //    }
        //    return true;
        //}


        public string GenerarPassword(int longitud)
        {

            using (var crypto = new RNGCryptoServiceProvider())
            {
                var bits = (longitud * 6);
                var byte_size = ((bits + 7) / 8);
                var bytesarray = new byte[byte_size];
                crypto.GetBytes(bytesarray);
                return Convert.ToBase64String(bytesarray);
            }
            //return contraseña;
        }

        public int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public string ContrasenaSegura(String contraseñaSinVerificar)
        {

            string msj = "";
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[A-Z]");
            Regex letrasM = new Regex(@"[a-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            //si no contiene las letras, regresa false
            if (!letras.IsMatch(contraseñaSinVerificar))
            {
                msj += "<p> Al menos una letra Mayuscula </p>";

            }
            //si no contiene las letras, regresa false
            if (!letrasM.IsMatch(contraseñaSinVerificar))
            {
                msj += " <p> Al menos una letra Minúscula </p>";
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(contraseñaSinVerificar))
            {
                msj += " <p> Al menos un número </p>";
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(contraseñaSinVerificar))
            {
                msj += " <p> Al menos un caracter especial </p> ";
            }



            return msj;
        }

    }

}