using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.InicioPkg;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Helper
{
    public class BodyMail
    {
        public int formulario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string rut { get; set; }
        public string telefono { get; set; }
        public string telMovil { get; set; }
        public string email { get; set; }
        public string region { get; set; }
        public string comuna { get; set; }
        public string direccion { get; set; }
        public string operacion { get; set; }
        public string patente { get; set; }
        public string mensaje { get; set; }
        public string certicado { get; set; }
        public string tipoContacto { get; set; }
        public string nomRepresent { get; set; }
        public string rutRepresent { get; set; }
        public string recepCorreo { get; set; }
        public string recepRetiro { get; set; }
        public List<ProductoServicio> lstProductoServicio { get; set; }
        public List<AttachMail> lstAttachMail { get; set; }
        public List<AddressMail> lstAddressMail { get; set; }

        public BodyMail GetBodyMailContacto(FormContacto formContacto)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.Contacto, formContacto.tipoConsultaCont);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.Contacto,
                nombre = formContacto.nombreCont,
                apellido = formContacto.apellidoCont,
                rut = formContacto.rutCont,
                telefono = formContacto.telefonoCont,
                region = formContacto.regionCont,
                comuna = formContacto.comunaCont,
                direccion = formContacto.direccionCont,
                email = formContacto.emailCont,
                mensaje = formContacto.mensajeCont,
                tipoContacto = formContacto.tipoConsultaCont,

                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }

        public BodyMail GetBodyMailCertificado(FormCertificado formCertificado)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            if (formCertificado.file1Cert != null)
            {
                lstAttachMail = new List<AttachMail>()
                {
                    new AttachMail() { archivo = formCertificado.file1Cert, nombre = formCertificado.file1Cert.FileName, extension = System.IO.Path.GetExtension(formCertificado.file1Cert.FileName) },
                    new AttachMail() { archivo = formCertificado.file2Cert, nombre = formCertificado.file2Cert.FileName, extension = System.IO.Path.GetExtension(formCertificado.file2Cert.FileName) }
                };
            }
            else
            {
                lstAttachMail = new List<AttachMail>()
                {
                    new AttachMail() { archivo = formCertificado.file2Cert, nombre = formCertificado.file2Cert.FileName, extension = System.IO.Path.GetExtension(formCertificado.file2Cert.FileName) }
                };
            }

        

            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.Certificado, formCertificado.certificadoCert);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.Certificado,
                nombre = formCertificado.nombreCert,
                apellido = formCertificado.apellidoCert,
                rut = formCertificado.rutCert,
                email = formCertificado.emailCert,
                region = formCertificado.regionCert,
                comuna = formCertificado.comunaCert,
                direccion = formCertificado.direccionCert,
                telMovil = formCertificado.telMovilCert,
                operacion = formCertificado.operacionCert,
                patente = formCertificado.patenteCert,
                mensaje = formCertificado.mensajeCert,
                certicado = formCertificado.certificadoCert,

                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }

        public BodyMail GetBodyMailPortSolicitud(FormPortSolicitud portSolicitud)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            lstAttachMail = new List<AttachMail>()
            {
                new AttachMail() { archivo = portSolicitud.file1PortSoli, nombre = portSolicitud.file1PortSoli.FileName, extension = System.IO.Path.GetExtension(portSolicitud.file1PortSoli.FileName) },
                new AttachMail() { archivo = portSolicitud.file2PortSoli, nombre = portSolicitud.file2PortSoli.FileName, extension = System.IO.Path.GetExtension(portSolicitud.file2PortSoli.FileName) },
                new AttachMail() { archivo = portSolicitud.file3PortSoli, nombre = portSolicitud.file3PortSoli.FileName, extension = System.IO.Path.GetExtension(portSolicitud.file3PortSoli.FileName) }
            };

            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.PortSolicitud, null);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.PortSolicitud,
                nombre = portSolicitud.nombrePortSoli,
                rut = portSolicitud.rutPortSoli,
                telefono = portSolicitud.telefonoPortSoli,
                email = portSolicitud.emailPortSoli,
                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }

        public BodyMail GetBodyMailPortCertificado(FormPortCertificado formPortCertificado, List<ProductoServicio> lstProductoServicio)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            lstAttachMail = new List<AttachMail>()
            {
                new AttachMail() { archivo = formPortCertificado.file1PortCert, nombre = formPortCertificado.file1PortCert.FileName, extension = System.IO.Path.GetExtension(formPortCertificado.file1PortCert.FileName) }

            };
            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.PortCertificado, formPortCertificado.certificadoPortCert);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.PortCertificado,
                nombre = formPortCertificado.nombrePortCert,
                rut = formPortCertificado.rutPortCert,
                email = formPortCertificado.emailPortCert,
                region = formPortCertificado.regionPortCert,
                comuna = formPortCertificado.comunaPortCert,
                direccion = formPortCertificado.direccionPortCert,
                telMovil = formPortCertificado.telMovilPortCert,
                certicado = formPortCertificado.certificadoPortCert,
                nomRepresent = formPortCertificado.nombreRepPortCert,
                rutRepresent = formPortCertificado.rutRepPortCert,
                recepCorreo = formPortCertificado.recepCorreoPortCert,
                recepRetiro = formPortCertificado.recepRetiroPortCert,

                lstProductoServicio = lstProductoServicio,
                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }

        public BodyMail GetBodyMailActDatos(FormActDatos formActDatos)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.ActualizaDatos, null);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.ActualizaDatos,
                rut = formActDatos.rutActDatos,
                nombre = formActDatos.nombreActDatos,
                direccion = formActDatos.direccionActDatos,
                comuna = formActDatos.comunaActDatos,
                telMovil = formActDatos.telMovilActDatos,
                telefono = formActDatos.telefonoActDatos,
                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }

        public BodyMail GetBodyMailTrabNos(FormTrabNos formTrabNos)
        {
            BodyMail bodyMail = new BodyMail();
            AddressMail addressMail = new AddressMail();
            List<AttachMail> lstAttachMail = new List<AttachMail>();
            List<AddressMail> lstAddressMail = new List<AddressMail>();

            lstAttachMail = new List<AttachMail>()
            {
                new AttachMail() { archivo = formTrabNos.fileTrabNos, nombre = formTrabNos.fileTrabNos.FileName, extension = System.IO.Path.GetExtension(formTrabNos.fileTrabNos.FileName) }

            };

            lstAddressMail = addressMail.GetEmailDeriv((int)Objeto.Formulario.TrabajaConNosotros, null);

            bodyMail = new BodyMail()
            {
                formulario = (int)Objeto.Formulario.TrabajaConNosotros,
                nombre = formTrabNos.nombreTrabNos,
                apellido = formTrabNos.apellidoTrabNos,
                telMovil = formTrabNos.telMovilTrabNos,
                email = formTrabNos.emailTrabNos,
                region = formTrabNos.regionTrabNos,
                comuna = formTrabNos.comunaTrabNos,
                mensaje = formTrabNos.mensajeTrabNos,
                lstAddressMail = lstAddressMail,
                lstAttachMail = lstAttachMail
            };


            return bodyMail;
        }
    }


}