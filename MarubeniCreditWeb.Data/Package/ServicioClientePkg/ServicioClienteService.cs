using System;
using System.Collections.Generic;
using System.Linq;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.Dtos;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class ServicioClienteService
    {
        public List<PregutaFrecuente> GetListPregFrecuentes()
        {
            List<PregutaFrecuente> retorno = new List<PregutaFrecuente>();

            try
            {

                retorno = new List<PregutaFrecuente>()
                {
                new PregutaFrecuente(){ pregunta =  "¿Cómo puedo pedir un certificado?", respuesta = "Lo puedes hacer a través del siguiente formulario -> ", urlTexto ="formulario de solicitud de certificados.", url="MostrarFormCertificado1()", idTipoUrl=(int)Objeto.TipoUrl.modal,  orden = 1},
                new PregutaFrecuente(){ pregunta =  "¿Dónde puedo cancelar las cuotas de mi crédito?", respuesta = "Aquí puedes encontrar todas las opciones de pago de tu crédito -> ", urlTexto ="lugares de pago.", urlAction="LugaresPago", urlController="Home", idTipoUrl=(int)Objeto.TipoUrl.urlVista, orden = 2},
                new PregutaFrecuente(){ pregunta =  "¿Cómo puedo actualizar mis datos de contacto?", respuesta = "Lo puedes hacer directamente en la página web -> ", urlTexto ="actualiza tus datos.",url= "MostrarFormActDatos()", idTipoUrl = (int)Objeto.TipoUrl.modal, orden = 3},
                new PregutaFrecuente(){ pregunta =  "¿Cómo puedo pedir mi Prepago?", respuesta = "La solicitud la puedes hacer en el siguiente link -> ", respuesta2="Esta solicitud demora 48 horas luego de recibido todos los documentos requeridos.", urlTexto ="solicitudes de pre pago.", url="MostrarFormPortSolicitud()", idTipoUrl=(int)Objeto.TipoUrl.modal, orden = 4},
                new PregutaFrecuente(){ pregunta =  "Se bloqueó mi clave del portal. ¿Cómo la recupero?", respuesta = "Solicitar vía correo electrónico la restauración de clave a uno de nuestros agentes:\n marcela.fajardo@marubenicredit.cl\n jose.fontecilla@marubenicredit.cl.\n Importante: en asunto de correo señalar “Desbloqueo clave”", orden = 5},
                new PregutaFrecuente(){ pregunta =  "¿Qué hago si pierdo mis cupones de pago?", respuesta = "Puedes solicitar tus cupones de pago en el siguiente correo: contacto@marubenicredit.cl", orden = 6},
                new PregutaFrecuente(){ pregunta =  "¿Qué hago si no he recibido mis cupones de pago?", respuesta = "Puedes solicitar tus cupones de pago en el siguiente correo: contacto@marubenicredit.cl", orden = 7},
                new PregutaFrecuente(){ pregunta =  "¿Qué hago si ya pagué y me están llamando de Cobranzas?", respuesta = "Enviar correo con comprobante de pago a jose.fontecilla@marubenicredit.cl\n Debes adjuntar rut de titular y teléfono de contacto", orden = 8},
                new PregutaFrecuente(){ pregunta =  "¿Qué hago si tengo un siniestro por robo, fallecimiento y pérdida total?", respuesta = "Enviar correo a seguros@marubenicredit.cl", orden = 9},
                new PregutaFrecuente(){ pregunta =  "¿Cómo puedo repactar mi crédito?", respuesta = "Se deben contactar vía correo electrónico  jose.fontecilla@marubenicredit.cl y marcela.fajardo@marubenicredit.cl", orden = 10},
                new PregutaFrecuente(){ pregunta =  "¿Qué debo hacer para alzar mi prenda?", respuesta = "Le comunicamos que con fecha 25 de septiembre de 2015 se publicó la Ley N°20.855 que regula el alzamiento de hipotecas y prendas que caucionen créditos, la que entró en vigencia el pasado 23 de enero de 2016. La misma normativa establece que esta Ley será aplicable a todos los créditos íntegramente pagados con posterioridad a dicha fecha, además de establecer algunas regulaciones para créditos anteriores. El objetivo de esta nueva regulación es hacer el procedimiento de alzamiento de la prenda mucho más claro para los consumidores, estableciendo nuevos plazos y reglas para el proveedor encargado de realizar esta gestión. En virtud de esta nueva normativa, Marubeni Credit le comunica los nuevos derechos que le asisten en caso de constituir prenda sin desplazamiento al momento de contratar su crédito automotriz:\n\n"+
                                                    " - Marubeni Credit debe tramitar el alzamiento de la prenda sin desplazamiento que se haya constituido para garantizar su crédito automotriz.\n  "+
                                                    " - Por el tipo de prenda utilizado en nuestros financiamientos, estas gestiones deben iniciarse una vez pagado íntegramente el crédito y Marubeni Credit tendrá un plazo de 45 días desde que se extinguen las obligaciones o se realiza la solicitud para ingresar la documentación respectiva ante el Registro de Prendas sin Desplazamiento que lleva el Servicio de Registro Civil e Identificación.\n  " +
                                                    " - La nueva ley permite la realización de alzamientos masivos, de manera de hacer el procedimiento más ágil y expedito.\n  "+
                                                    " - Marubeni Credit le informará vía correo electrónico que su alzamiento se encuentra tramitado.\n  "+
                                                    " - En caso que Ud. haya contratado una prenda que opere como garantía general (la que no está obligado a mantener para acceder a nuevos créditos) Marubeni Credit le informará este hecho, dentro de 20 días de pagadas íntegramente las deudas garantizadas con ella, de manera que Ud. pueda indicarnos si desea que no alcemos dicha prenda.\n\n"+
                                                    "Con todo, si Ud. ya ha pagado íntegramente su deuda y no mantiene otras obligaciones pendientes, siempre puede solicitar el alzamiento de la garantía llamando al 226803340 o al correo electrónico alzamientos@marubenicredit.cl. Si usted desea saber si aún mantiene la garantía de su crédito o mantiene otras prendas vigentes puede consultarlo directamente en el Registro de Prendas Sin Desplazamiento que mantiene el Registro Civil.",
                                                     orden = 11},
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }


        public List<PregutaFrecuente> GetListPregFrecuentesPort()
        {
            List<PregutaFrecuente> retorno = new List<PregutaFrecuente>();

            try
            {

                retorno = new List<PregutaFrecuente>()
                {
                new PregutaFrecuente(){ pregunta =  "¿Para qué sirve la portabilidad financiera?", respuesta = "La portabilidad financiera permite a los clientes cambiarse de institución financiera de modo de obtener mejores condiciones en los productos y/o servicios previamente contratados con un proveedor inicial.", orden = 1},
                new PregutaFrecuente(){ pregunta =  "¿Quiénes intervienen en la portabilidad financiera?", respuesta = "El cliente, el proveedor inicial, con quien se contrataron los productos o servicios vigentes, y un nuevo proveedor, con quien se contratarán nuevos productos o servicios.", orden = 2},
                new PregutaFrecuente(){ pregunta =  "¿Puedo solicitar una portabilidad financiera a la misma institución?", respuesta = "Sí, el cliente podrá solicitar una portabilidad al mismo proveedor para que ofrezca mejores condiciones financieras.", orden = 3},
                new PregutaFrecuente(){ pregunta =  "¿A quién debo solicitar la portabilidad financiera?", respuesta = "Se debe solicitar a la nueva empresa que el cliente desea portarse, mediante una solicitud de portabilidad que se encontrará disponible en cada entidad financiera." , orden = 4},
                new PregutaFrecuente(){ pregunta =  "¿Cómo es el procedimiento de portabilidad?", respuesta = "El procedimiento varía según las condiciones particulares de cada producto o servicio financiero. En general se considera: i) solicitud, ii) oferta, iii) aceptación, iv) suscripción de contratos, v) pago y cierre de los productos o servicios financieros, y  vi) modificaciones de garantías y alzamientos si proceden.", orden = 5},
                new PregutaFrecuente(){ pregunta =  "¿Puedo arrepentirme de la portabilidad una vez aceptada?", respuesta = "Sí, el cliente puede retractarse de la aceptación de la oferta hasta la suscripción de los nuevos contratos de crédito con la nueva institución financiera.", orden = 6},
                new PregutaFrecuente(){ pregunta =  "¿Qué es el mandato de término?", respuesta = "Aceptada la oferta de portabilidad, el cliente entrega tácitamente un mandato al nuevo proveedor, para pagar y solicitar el cierre de los productos al proveedor inicial.", orden = 7},
                new PregutaFrecuente(){ pregunta =  "¿Qué significa la portabilidad con subrogación?", respuesta = "Implica que el cliente cambia de institución financiera, utilizando la misma garantía – prenda o hipoteca - que tenía con el proveedor inicial, para efectos de garantizar el nuevo crédito.", orden = 8},
                new PregutaFrecuente(){ pregunta =  "¿Cómo puedo solicitar la portabilidad financiera a Marubeni Credit?", respuesta = "Para portarse a Marubeni Credit el cliente deberá llenar y enviar el formulario dispuesto en nuestros mesones en concesionarios y en la sección solicitud portabilidad financiera de nuestra web. Para ello, el cliente debe contar con información detallada sobre sus productos o servicios vigentes que pretende portar.", orden = 9},
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<DetalleSeccion> GetListOtrosDocs()
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {

                retorno = new List<DetalleSeccion>()
                {
                new DetalleSeccion() { btnTexto = "consejos financiamiento", urlAction= "Consejos", urlController ="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                new DetalleSeccion() { btnTexto = "anexo servicio al cliente", urlAction= "Anexo", urlController ="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                new DetalleSeccion() { btnTexto = "portabilidad financiera", urlAction= "Portabilidad", urlController ="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }
        public List<TipoConsulta> GetListTipoConsulta(int chek= 0)
        {
            List<TipoConsulta> retorno = new List<TipoConsulta>();

            try
            {

                retorno = new List<TipoConsulta>()
                {
                new TipoConsulta() { tipoConsulta = "Cobranzas", emailDeriv = "contacto@marubenicredit.cl", orden = 1},
                new TipoConsulta() { tipoConsulta = "Prendas o alzamientos", emailDeriv = "alzamientos@marubenicredit.cl", orden = 2},
                new TipoConsulta() { tipoConsulta = "Autoplan", emailDeriv = "contacto@marubenicredit.cl", orden = 3},
                new TipoConsulta() { tipoConsulta = "Cupón de Pago", emailDeriv = "contacto@marubenicredit.cl", orden = 4},
                new TipoConsulta() { tipoConsulta = "Seguros", emailDeriv = "seguros@marubenicredit.cl", orden = 5},
                new TipoConsulta() { tipoConsulta = "PAC", emailDeriv = "contacto@marubenicredit.cl", orden = 6 },
                new TipoConsulta() { tipoConsulta = "Reclamos", emailDeriv = "contacto@marubenicredit.cl", orden = 7},
                new TipoConsulta() { tipoConsulta = "Requisitos para un crédito", emailDeriv = "contacto@marubenicredit.cl", orden = 8 },
                new TipoConsulta() { tipoConsulta = "Solicitud nuevo crédito", emailDeriv = "contacto@marubenicredit.cl", orden = 9},
                new TipoConsulta() { tipoConsulta = "Otras consultas", emailDeriv = "contacto@marubenicredit.cl", orden = 10 }
                };

               

                    foreach (var item in retorno.Where(x => x.orden == chek))
                    {
                        item.check = true;
                    }

            }            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<Certificado> GetListCertificados()
        {
            List<Certificado> retorno = new List<Certificado>();

            try
            {
                retorno = new List<Certificado>()
                {
                new Certificado() { certificado = "Certificado sin deuda", emailDeriv1 ="contacto@marubenicredit.cl", emailDeriv2 = "marcela.fajardo@marubenicredit.cl", orden = 1 },
                new Certificado() { certificado = "Certificado con deuda", emailDeriv1 ="contacto@marubenicredit.cl", emailDeriv2 = "marcela.fajardo@marubenicredit.cl", orden = 2 },
                new Certificado() { certificado = "Certificado de prepago", emailDeriv1 ="jose.fontecilla @marubenicredit.cl", emailDeriv2 = "prepagos@marubenicredit.cl", orden = 3 },
                new Certificado() { certificado = "Certificado de alzamiento en trámite", emailDeriv1 ="alzamientos@marubenicredit.cl", emailDeriv2 = "", orden = 4 }
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<Certificado> GetListPortCertificados()
        {
            List<Certificado> retorno = new List<Certificado>();

            try
            {
                retorno = new List<Certificado>()
                {
                new Certificado() { certificado = "Certificado de Liquidación", emailDeriv1 ="portabilidad.financiera@marubenicredit.cl", emailDeriv2 = "", orden = 1 },
                new Certificado() { certificado = "Certificado de Pago del Impuesto de Timbres y Estampillas", emailDeriv1 ="portabilidad.financiera@marubenicredit.cl", emailDeriv2 = "", orden = 2 },
                new Certificado() { certificado = "Certificado de Tasación garantía, en caso de haberse practicado", emailDeriv1 ="portabilidad.financiera@marubenicredit.cl", emailDeriv2 = "", orden = 3 },
                new Certificado() { certificado = "Si desea el (los) certificado(s) para todos sus productos vigentes marque aquí", emailDeriv1 ="portabilidad.financiera@marubenicredit.cl", emailDeriv2 = "", orden = 4 }
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<EmailDeriv> GetEmail(int formulario, string parametro)
        {
            List<EmailDeriv> retorno = new List<EmailDeriv>();

            try
            {
                if (formulario == (int)Objeto.Formulario.Contacto)
                {
                    List<TipoConsulta> lstTipoConsulta = new List<TipoConsulta>();
                    lstTipoConsulta = GetListTipoConsulta();

                    retorno = new List<EmailDeriv>()
                    {
                    new EmailDeriv() { emailDeriv = lstTipoConsulta.Where(c => c.tipoConsulta == parametro).FirstOrDefault().emailDeriv},
                    };
                    //retorno = new List<EmailDeriv>()
                    //{
                    ////new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                    ////new EmailDeriv() { emailDeriv ="claudia.ortiz@marubenicredit.cl"},
                    //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}
                    //};
                }
                if (formulario == (int)Objeto.Formulario.Certificado)
                {
                    List<Certificado> lstCertificado = new List<Certificado>();
                    lstCertificado = GetListCertificados();

                    retorno = new List<EmailDeriv>()
                    {
                    new EmailDeriv() { emailDeriv = lstCertificado.Where(c => c.certificado == parametro).FirstOrDefault().emailDeriv1},
                    new EmailDeriv() { emailDeriv = lstCertificado.Where(c => c.certificado == parametro).FirstOrDefault().emailDeriv2},

                    };
                    //retorno = new List<EmailDeriv>()
                    //{
                    ////new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                    ////new EmailDeriv() { emailDeriv ="claudia.ortiz@marubenicredit.cl"},
                    //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}
                    //};
                }
                if (formulario == (int)Objeto.Formulario.PortSolicitud)
                {


                    retorno = new List<EmailDeriv>()
                    {
                    new EmailDeriv() { emailDeriv ="portabilidad.financiera@marubenicredit.cl"},

                    };
                    //retorno = new List<EmailDeriv>()
                    //{
                    ////new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                    ////new EmailDeriv() { emailDeriv ="claudia.ortiz@marubenicredit.cl"},
                    //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}
                    //};
                }
                if (formulario == (int)Objeto.Formulario.PortCertificado)
                {
                    List<Certificado> lstCertificado = new List<Certificado>();
                    lstCertificado = GetListPortCertificados();

                    retorno = new List<EmailDeriv>()
                    {
                    new EmailDeriv() { emailDeriv = lstCertificado.Where(c => c.certificado == parametro).FirstOrDefault().emailDeriv1}
                    };

                    //retorno = new List<EmailDeriv>()
                    //{
                    ////new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                    ////new EmailDeriv() { emailDeriv ="claudia.ortiz@marubenicredit.cl"},
                    //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}
                    //};
                }

                if (formulario == (int)Objeto.Formulario.ActualizaDatos)
                {
                    retorno = new List<EmailDeriv>()
                    {
                    new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                    new EmailDeriv() { emailDeriv ="marcela.avaria@marubenicredit.cl"},
                    new EmailDeriv() { emailDeriv ="marcela.fajardo@marubenicredit.cl"}
                    //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}
                    };
                }
                if (formulario == (int)Objeto.Formulario.TrabajaConNosotros)
                {
                    retorno = new List<EmailDeriv>()
                    {
                        new EmailDeriv() { emailDeriv ="ximena.gonzalez@marubenicredit.cl"}
                        //new EmailDeriv() { emailDeriv ="contacto@marubenicredit.cl"},
                        //new EmailDeriv() { emailDeriv ="claudia.ortiz@marubenicredit.cl"},
                        //new EmailDeriv() { emailDeriv ="evelyn.alvarez@marubeni.cl"}

                        //new EmailDeriv() { emailDeriv ="gerenciacomercial.marubenicredit@marubenicredit.cl "},
                    };
                }


            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }
    }
}
