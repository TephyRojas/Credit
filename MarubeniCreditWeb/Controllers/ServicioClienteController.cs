using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using MarubeniCreditWeb.Data.Package.ArchivosPkg;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.RegionComunaPkg;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;
using MarubeniCreditWeb.Helper;
using MarubeniCreditWeb.Models;
using Microsoft.Security.Application;

namespace MarubeniCreditWeb.Controllers
{
    public class ServicioClienteController : Controller
    {
        EnvioMail envioMail = new EnvioMail();
        BodyMail bodyMail = new BodyMail();
        private Util util = new Util();
        private static string rutaDownload = "/App_Data/Download/";
        private static string rutaUpload = "/App_Data/Upload/";

        // GET: ServicioCliente
        public ActionResult ServicioCliente()
        {
            ServicioClienteModel servicioClienteModel = new ServicioClienteModel();
            servicioClienteModel = servicioClienteModel.GetServicioCliente();
            return View(servicioClienteModel);
        }
        public ActionResult Consejos()
        {
            return View();
        }
        public ActionResult Anexo()
        {
            return View();
        }
        public ActionResult Portabilidad()
        {
            PortabilidadModel portabilidadModel = new PortabilidadModel();
            portabilidadModel = portabilidadModel.GetPortabilidad();
            return View(portabilidadModel);
        }
        public ActionResult MostrarFormContacto1(int chek = 0)
        {
            FormContactoModel formContactoModel = new FormContactoModel();
            formContactoModel = formContactoModel.GetFormContacto(chek);
            ViewBag.Key = util.SitioKey;
            ViewBag.ButonDisable = chek;
            return PartialView("_FormContacto", formContactoModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarContacto([Bind(Include = "nombreCont,apellidoCont,rutCont,telefonoCont,regionCont,comunaCont,direccionCont,emailCont,mensajeCont,tipoConsultaCont")] FormContacto formContacto)
        {
            if (ModelState.IsValid)
            {
                if(formContacto.tipoConsultaCont == null)
                {
                    formContacto.tipoConsultaCont = "PAC";
                }
                //formContacto.mensajeCont = Sanitizer.GetSafeHtml(formContacto.mensajeCont);
                //formContacto.tipoConsultaCont = Sanitizer.GetSafeHtml(formContacto.tipoConsultaCont);
                string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                bodyMail = bodyMail.GetBodyMailContacto(formContacto);
                envioMail.EnviarMail("Hemos recibido una consulta de " + formContacto.tipoConsultaCont, bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.Contacto);
            }
            else
            {
                jsonReturn jsonReturn = new jsonReturn();
                jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }

            return PartialView("_FormFinal");
        }

        public ActionResult MostrarFormCertificado1()
        {
            FormCertificadoModel formCertificadoModel = new FormCertificadoModel();
            formCertificadoModel = formCertificadoModel.GetFormCertificado();
            ViewBag.Key = util.SitioKey;
            return PartialView("_FormCertificado", formCertificadoModel);
        }
        [HttpGet]

        public ActionResult GetComunasByRegion(int idRegion)
        {
            RegionComunaService regionComunaService = new RegionComunaService();
            List<Comuna> lstComuna = regionComunaService.GetListComunas(idRegion);

            return Json(lstComuna, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarCertificado([Bind(Include = "nombreCert,apellidoCert,rutCert,emailCert,regionCert,comunaCert,direccionCert,telMovilCert,operacionCert,patenteCert,mensajeCert,certificadoCert,file2Cert,file1Cert")] FormCertificado formCertificado)
        {

            if (ModelState.IsValid)
            {
                //formCertificado.mensajeCert = Sanitizer.GetSafeHtml(formCertificado.mensajeCert);
                //formCertificado.certificadoCert = Sanitizer.GetSafeHtml(formCertificado.certificadoCert);
                string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                bodyMail = bodyMail.GetBodyMailCertificado(formCertificado);
                envioMail.EnviarMail("Hemos recibido una solicitud de " + formCertificado.certificadoCert, bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.Certificado);
            }
            else
            {
                jsonReturn jsonReturn = new jsonReturn();
                jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }

            return PartialView("_FormFinal");
        }

        public FileResult DownloadFile(int codFile)
        {
            string ruta = Server.MapPath(rutaDownload);
            FileResult result = null;

            ArchivoService archivoService = new ArchivoService();
            List<ArchivoDescargable> lstArchivoDescargable = archivoService.GetListArchivos();
            Dictionary<int, ArchivoDescargable> dicArchivoDescargable = lstArchivoDescargable.ToDictionary(x => x.codigo);

            if (dicArchivoDescargable.TryGetValue(codFile, out ArchivoDescargable salida))
            {
                string FileVirtualPath = ruta + salida.nombre + salida.extension;
                if (System.IO.File.Exists(FileVirtualPath))
                {
                    return File(FileVirtualPath, "application/force- download", Path.GetFileName(FileVirtualPath));

                }

            }

            return result;


        }

        public ActionResult MostrarFormPortSolicitud()
        {
            ViewBag.Key = util.SitioKey;
            return PartialView("_FormPortSolicitud");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarPortSolicitud([Bind(Include = "nombrePortSoli,rutPortSoli,telefonoPortSoli,emailPortSoli,file1PortSoli,file2PortSoli,file3PortSoli")] FormPortSolicitud formPortSolicitud)
        {
   
            if (ModelState.IsValid)
            {
                string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                bodyMail = bodyMail.GetBodyMailPortSolicitud(formPortSolicitud);
                envioMail.EnviarMail("Hemos recibido una solicitud de portabilidad financiera", bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.PortSolicitud);
            }
            else
            {
                jsonReturn jsonReturn = new jsonReturn();
                jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }


            return PartialView("_FormFinal");
        }

        public ActionResult MostrarFormPortCertificado1()
        {
            FormPortCertModel formPortCertModel = new FormPortCertModel();
            formPortCertModel = formPortCertModel.GetFormPortCertificado();
            ViewBag.Key = util.SitioKey;
            return PartialView("_FormPortCertificado", formPortCertModel);
        }

        public ActionResult AgregarProdFinanc()
        {
            return PartialView("_NuevoProdFinanc");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarPortCertificado([Bind(Include = "nombrePortCert,rutPortCert,emailPortCert,regionPortCert,comunaPortCert,direccionPortCert,telMovilPortCert,nombreRepPortCert,rutRepPortCert,certificadoPortCert,file1PortCert,prodServPortCert,nroCredPortCert,patentePortCert,recepCorreoPortCert,recepRetiroPortCert")]  FormPortCertificado formPortCertificado)
        {
            if (ModelState.IsValid)
            {
                List<ProductoServicio> lstProductoServicio = new List<ProductoServicio>();

                if (formPortCertificado.prodServPortCert != null)
                {
                    List<string> lstProdServ = formPortCertificado.prodServPortCert.Split(',').ToList();
                    List<string> lstNroCred = formPortCertificado.nroCredPortCert.Split(',').ToList();
                    List<string> lstPatente = formPortCertificado.patentePortCert.Split(',').ToList();

                    var largoArray = lstProdServ.Count();
                    for (int i = 0; i < largoArray; i++)
                    {
                        ProductoServicio productoServicio = new ProductoServicio();
                        productoServicio.prodServ = lstProdServ[i];
                        productoServicio.nroCred = lstNroCred[i];
                        productoServicio.patente = lstPatente[i];

                        lstProductoServicio.Add(productoServicio);
                    }
                }
               

                //formPortCertificado.certificadoPortCert = Sanitizer.GetSafeHtml(formPortCertificado.certificadoPortCert);               
                string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                bodyMail = bodyMail.GetBodyMailPortCertificado(formPortCertificado, lstProductoServicio);
                envioMail.EnviarMail("Hemos recibido una solicitud de certificado de portablidad financiera", bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.PortCertificado);
            }
            else
            {
                jsonReturn jsonReturn = new jsonReturn();
                jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }


            return PartialView("_FormFinal");
        }



    }

}





