using System.Collections.Generic;
using System.Web.Mvc;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.InicioPkg;
using MarubeniCreditWeb.Data.Package.RegionComunaPkg;
using MarubeniCreditWeb.Helper;
using MarubeniCreditWeb.Models;
using Microsoft.Security.Application;

namespace MarubeniCreditWeb.Controllers
{
    public class HomeController : Controller
    {
        EnvioMail envioMail = new EnvioMail();
        BodyMail bodyMail = new BodyMail();
        private Util util = new Util();
        public ActionResult Index()
        {

            InicioModel inicioModel = new InicioModel();

            inicioModel = inicioModel.GetInicioModel();

            return View(inicioModel);

        }

        public ActionResult NuestraEmpresa()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LugaresPago()
        {
            LugaresPagoModel lugaresPagoModel = new LugaresPagoModel();

            lugaresPagoModel = lugaresPagoModel.GetLugaresPagoModel();

            return View(lugaresPagoModel);

        }

        public ActionResult Simulador()
        {

            return View();

        }
        public ActionResult MostrarFormActDatos()
        {
            ViewBag.Key = util.SitioKey;
            return PartialView("_FormActDatos");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardarActDatos([Bind(Include = "rutActDatos,nombreActDatos,direccionActDatos,comunaActDatos,telMovilActDatos,telefonoActDatos")] FormActDatos formActDatos)
        {

            if (ModelState.IsValid)
            {
                //formActDatos.comunaActDatos = Sanitizer.GetSafeHtml(formActDatos.comunaActDatos);
                string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                bodyMail = bodyMail.GetBodyMailActDatos(formActDatos);
                envioMail.EnviarMail("Recibimos una actualización de datos de cliente", bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.ActualizaDatos);
            }
            else
            {
                jsonReturn jsonReturn = new jsonReturn();
                jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }

            return PartialView("_FormFinalActDatos");
        }



        public ActionResult TrabajaConNosotros()
        {
            ViewBag.Key = util.SitioKey;
            RegionComunaService regionComunaService = new RegionComunaService();
            ViewData["lstRegion"] = regionComunaService.GetListRegiones();
           // ViewData["lstComuna"] = regionComunaService.GetListComunas(0);
            ViewBag.Inicio = 1;
            return View();

        }

        public ActionResult GetComunasByRegion(int idRegion)
        {
            ViewBag.Inicio = 0;
            RegionComunaService regionComunaService = new RegionComunaService();
            List<Comuna> lstComuna = regionComunaService.GetListComunas(idRegion);

            return Json(lstComuna, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GuardarTrabNos([Bind(Include = "nombreTrabNos,apellidoTrabNos,telMovilTrabNos,emailTrabNos,regionTrabNos,comunaTrabNos,mensajeTrabNos,fileTrabNos")] FormTrabNos formTrabNos)
        {
            jsonReturn jsonReturn = new jsonReturn();
            try
            {

                if (ModelState.IsValid)
                {
                    //formTrabNos.mensajeTrabNos = Sanitizer.GetSafeHtml(formTrabNos.mensajeTrabNos);
                    string pathCabecera = Server.MapPath(@"~/img/imgs/logo-email.png");
                    string pathFooter = Server.MapPath(@"~/img/imgs/logo-footer.png");
                    bodyMail = bodyMail.GetBodyMailTrabNos(formTrabNos);
                    envioMail.EnviarMail("Recibimos un candidato en la sección trabaja con nosotros", bodyMail, pathCabecera, pathFooter, (int)Objeto.Formulario.TrabajaConNosotros);
                }
                else
                {
                    jsonReturn = util.RespuestaJson(false, ModelState, "Datos incompletos, por favor ingresar campos marcados como obligatorios", "");
                    return Json(jsonReturn, JsonRequestBehavior.AllowGet);
                }

            }
            catch
            {
                jsonReturn = util.RespuestaJson(false, ModelState, "Ha ocurrido un error, intente nuevamente por favor", "");
                return Json(jsonReturn, JsonRequestBehavior.AllowGet);
            }
            jsonReturn = util.RespuestaJson(true, ModelState, "Información Enviada", "");
            return Json(jsonReturn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Error()
        {

            return View();

        }

    }
}