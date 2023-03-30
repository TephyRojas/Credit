using System.Collections.Generic;
using System.Web.Mvc;
using MarubeniCreditWeb.Data.Package.MenuPkg;
using MarubeniCreditWeb.Models;

namespace MarubeniCreditWeb.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult TopBar()
        {
            TopBarModel menuModel = new TopBarModel();
            List<Menu> lstTopBar = menuModel.GetTopBar();
            return PartialView("_TopBar", lstTopBar);
        }

        public ActionResult NavBar()
        {
            NavBarModel navBarModel = new NavBarModel();
            navBarModel = navBarModel.GetNavBar();
            return PartialView("_NavBar", navBarModel);
        }

        public ActionResult Footer()
        {
            FooterModel footerModel = new FooterModel();
            footerModel = footerModel.GetFooterModel();
            return PartialView("_Footer", footerModel);
        }



    }
}
