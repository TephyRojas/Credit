using System;
using System.Drawing;
using MarubeniCreditWeb.Data.Package.Comun;

namespace MarubeniCreditWeb.Helper
{
    public class EnvioMail
    {
        private Util util = new Util();

        public bool EnviarMail(string Asunto, BodyMail bodyMail, string pathCabecera, string pathFooter, int formulario)
        {
            //string antiguedad = ""; string servicio = "";
            //Image b = Image.FromFile(pathCabecera);
            //ImageConverter ic = new ImageConverter();
            //byte[] ba = (byte[])ic.ConvertTo(b, typeof(byte[]));
            //string imagenCabecera = Convert.ToBase64String(ba, 0, ba.Length);

            Image bf = Image.FromFile(pathFooter);
            ImageConverter icf = new ImageConverter();
            byte[] baf = (byte[])icf.ConvertTo(bf, typeof(byte[]));
            string imagenFooter = Convert.ToBase64String(baf, 0, baf.Length);


            string Cuerpo = CuerpoMail(bodyMail, imagenFooter, formulario);

            bool envio = true;



            envio = util.SendMail(Asunto, Cuerpo, bodyMail.lstAddressMail, bodyMail.lstAttachMail);

            return envio;
        }
        public string CuerpoMail(BodyMail bodyMail, string imagenFooter, int formulario)
        {

            string Cuerpo = "";

            if (formulario == (int)Objeto.Formulario.ActualizaDatos)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido una actualización de datos de cliente:</p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + "</li>";
                Cuerpo = Cuerpo + "<li>Rut: " + bodyMail.rut + "</li>";
                Cuerpo = Cuerpo + "<li>Dirección: " + bodyMail.direccion + "</li>";
                Cuerpo = Cuerpo + "<li>Comuna: " + bodyMail.comuna + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono: " + bodyMail.telefono + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono Móvil: " + bodyMail.telMovil + "</li>";
                Cuerpo = Cuerpo + "</ul>";

                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }

            if (formulario == (int)Objeto.Formulario.TrabajaConNosotros)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido un candidato en la sección trabaja con nosotros:</p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + " " + bodyMail.apellido + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono Móvil: " + bodyMail.telMovil + "</li>";
                Cuerpo = Cuerpo + "<li>E-mail: " + bodyMail.email + "</li>";
                Cuerpo = Cuerpo + "<li>Región: " + bodyMail.region + "</li>";
                Cuerpo = Cuerpo + "<li>Comuna: " + bodyMail.comuna + "</li>";
                Cuerpo = Cuerpo + "</ul>";

                if (!string.IsNullOrEmpty(bodyMail.mensaje))
                {
                    Cuerpo = Cuerpo + "<p>Mensaje: " + bodyMail.mensaje + "</p>";
                }

                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }


            if (formulario == (int)Objeto.Formulario.Contacto)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido una solicitud de contacto:</p>";
                Cuerpo = Cuerpo + "<p>Tipo Consulta: <strong>" + bodyMail.tipoContacto + "</strong></p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + " " + bodyMail.apellido + "</li>";
                Cuerpo = Cuerpo + "<li>Rut: " + bodyMail.rut + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono: " + bodyMail.telefono + "</li>";
                Cuerpo = Cuerpo + "<li>Región: " + bodyMail.region + "</li>";
                Cuerpo = Cuerpo + "<li>Comuna: " + bodyMail.comuna + "</li>";
                Cuerpo = Cuerpo + "<li>Dirección: " + bodyMail.direccion + "</li>";
                Cuerpo = Cuerpo + "<li>E-mail: " + bodyMail.email + "</li>";

                Cuerpo = Cuerpo + "</ul>";

                if (!string.IsNullOrEmpty(bodyMail.mensaje))
                {
                    Cuerpo = Cuerpo + "<p>Mensaje: " + bodyMail.mensaje + "</p>";
                }

                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }

            if (formulario == (int)Objeto.Formulario.Certificado)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido una solicitud de certificado:</p>";
                Cuerpo = Cuerpo + "<p>Certificado: <strong>" + bodyMail.certicado + "</strong></p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + " " + bodyMail.apellido + "</li>";
                Cuerpo = Cuerpo + "<li>Rut: " + bodyMail.rut + "</li>";
                Cuerpo = Cuerpo + "<li>E-mail: " + bodyMail.email + "</li>";
                Cuerpo = Cuerpo + "<li>Región: " + bodyMail.region + "</li>";
                Cuerpo = Cuerpo + "<li>Comuna: " + bodyMail.comuna + "</li>";
                Cuerpo = Cuerpo + "<li>Dirección: " + bodyMail.direccion + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono Móvil: " + bodyMail.telMovil + "</li>";
                Cuerpo = Cuerpo + "<li>Operación: " + bodyMail.operacion + "</li>";
                Cuerpo = Cuerpo + "<li>Patente: " + bodyMail.patente + "</li>";

                Cuerpo = Cuerpo + "</ul>";

                if (!string.IsNullOrEmpty(bodyMail.mensaje))
                {
                    Cuerpo = Cuerpo + "<p>Mensaje: " + bodyMail.mensaje + "</p>";
                }

                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }

            if (formulario == (int)Objeto.Formulario.PortSolicitud)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido una solicitud de portabilidad:</p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + "</li>";
                Cuerpo = Cuerpo + "<li>Rut: " + bodyMail.rut + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono: " + bodyMail.telefono + "</li>";
                Cuerpo = Cuerpo + "<li>E-mail: " + bodyMail.email + "</li>";
                Cuerpo = Cuerpo + "</ul>";

                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }

            if (formulario == (int)Objeto.Formulario.PortCertificado)
            {

                Cuerpo = "<html><div style='font-family: Calibri, sans-serif; font-size:10.0pt; color:#242323;'> ";
                Cuerpo = Cuerpo + "<p>Ha recibido una solicitud de certificado de portabilidad financiera:</p>";
                Cuerpo = Cuerpo + "<p>Certificado: <strong>" + bodyMail.certicado + "</strong></p>";
                Cuerpo = Cuerpo + "<ul>";
                Cuerpo = Cuerpo + "<li>Nombre: " + bodyMail.nombre + "</li>";
                Cuerpo = Cuerpo + "<li>Rut: " + bodyMail.rut + "</li>";
                Cuerpo = Cuerpo + "<li>E-mail: " + bodyMail.email + "</li>";
                Cuerpo = Cuerpo + "<li>Región: " + bodyMail.region + "</li>";
                Cuerpo = Cuerpo + "<li>Comuna: " + bodyMail.comuna + "</li>";
                Cuerpo = Cuerpo + "<li>Dirección: " + bodyMail.direccion + "</li>";
                Cuerpo = Cuerpo + "<li>Teléfono Móvil: " + bodyMail.telMovil + "</li>";
                Cuerpo = Cuerpo + "<li>Nombre Representante: " + bodyMail.nomRepresent + "</li>";
                Cuerpo = Cuerpo + "<li>Rut Representante: " + bodyMail.rutRepresent + "</li>";

                Cuerpo = Cuerpo + "</ul>";


                Cuerpo = Cuerpo + "<p>Método de envío:</p>";
                Cuerpo = Cuerpo + "<ul>";
                if (!string.IsNullOrEmpty(bodyMail.recepCorreo))
                {
                    Cuerpo = Cuerpo + "<li>" + bodyMail.recepCorreo + "</li>";
                }
                if (!string.IsNullOrEmpty(bodyMail.recepRetiro))
                {
                    Cuerpo = Cuerpo + "<li>" + bodyMail.recepRetiro + "</li>";
                }

                Cuerpo = Cuerpo + "</ul>";

                Cuerpo = Cuerpo + "<div>";
                Cuerpo = Cuerpo + "<table style='width: 100%; font-family: Calibri, sans-serif; font-size:10.0pt;'>";
                Cuerpo = Cuerpo + "<tbody>";
                Cuerpo = Cuerpo + "<tr style='background-color: #ff0000; color: #ffffff;'>";
                Cuerpo = Cuerpo + "<th>Producto o Servicio</th>";
                Cuerpo = Cuerpo + "<th>Crédito Nro</th>";
                Cuerpo = Cuerpo + "<th>Patente vehículo</th>";
                Cuerpo = Cuerpo + "</tr>";
                foreach (var item in bodyMail.lstProductoServicio)
                {
                    Cuerpo = Cuerpo + "<tr style='color: #242323;'>";
                    Cuerpo = Cuerpo + "<td>" + item.prodServ + "</td>";
                    Cuerpo = Cuerpo + "<td>" + item.nroCred + "</td>";
                    Cuerpo = Cuerpo + "<td>" + item.patente + "</td>";
                    Cuerpo = Cuerpo + "</tr >";
                }

                Cuerpo = Cuerpo + "</tbody >";
                Cuerpo = Cuerpo + "</table >";

                Cuerpo = Cuerpo + "</div>";
                Cuerpo = Cuerpo + "<p><img src='data:image/png;base64," + imagenFooter + "'></p></br>";
                Cuerpo = Cuerpo + "</div></html>";
            }

            return Cuerpo;
        }


    }
}