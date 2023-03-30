using System.Web.Mvc;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Models;

namespace MarubeniCreditWeb.Controllers
{
    public class TipoCreditoController : Controller
    {
        // GET: TipoCredito
        public ActionResult TipoCreditoAuto()
        {
            TipoCreditoModel tipoCreditoModel = new TipoCreditoModel();

            tipoCreditoModel = tipoCreditoModel.GetTipoCreditoModel((int)Objeto.TipoVehiculo.Auto);

            return View(tipoCreditoModel);

        }

        // GET: TipoCredito/Details/5
        public ActionResult TipoCreditoMoto()
        {
            TipoCreditoModel tipoCreditoModel = new TipoCreditoModel();

            tipoCreditoModel = tipoCreditoModel.GetTipoCreditoModel((int)Objeto.TipoVehiculo.Moto);

            return View(tipoCreditoModel);
        }

        // GET: TipoCredito/Create
        public ActionResult TipoCreditoCamion()
        {
            TipoCreditoModel tipoCreditoModel = new TipoCreditoModel();

            tipoCreditoModel = tipoCreditoModel.GetTipoCreditoModel((int)Objeto.TipoVehiculo.Camion);

            return View(tipoCreditoModel);
        }

    }
}
