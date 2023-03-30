using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.MenuPkg;

namespace MarubeniCreditWeb.Models
{
    public class TopBarModel
    {
        public List<Menu> GetTopBar()
        {
            List<Menu> lstTopBar = new List<Menu>();
            MenuService menuService = new MenuService();
            lstTopBar = menuService.GetListTopBar();

            return lstTopBar;
        }

    }

    public class NavBarModel
    {
        public List<Menu> lstMenu { get; set; }
        public List<SubMenu> lstSubMenu { get; set; }
        public List<Menu> lstMenuMobile { get; set; }
        public Menu btnPrimario { get; set; }
        public Menu btnSecundario { get; set; }
        public NavBarModel GetNavBar()
        {
            NavBarModel navBarModel = new NavBarModel();
            MenuService menuService = new MenuService();
            navBarModel.lstMenu = menuService.GetListNavBarMenu();
            navBarModel.lstSubMenu = menuService.GetListNavBarSubMenu();
            navBarModel.lstMenuMobile = menuService.GetListNavBarMobile();
            navBarModel.btnPrimario = menuService.GetNavBarBoton((int)Objeto.Boton.Primario);
            navBarModel.btnSecundario = menuService.GetNavBarBoton((int)Objeto.Boton.Secundario);
            return navBarModel;
        }
    }

    public class FooterModel
    {
        public Menu logo { get; set; }
        public List<Menu> lstSucursales { get; set; }
        public Menu contacto { get; set; }
        public List<Menu> lstMenu { get; set; }

        public FooterModel GetFooterModel()
        {
            FooterModel footerModel = new FooterModel();
            MenuService menuService = new MenuService();

            footerModel.logo = menuService.GetFooterLogo();
            footerModel.lstSucursales = menuService.GetListFooterSucursales();
            footerModel.contacto = menuService.GetFooterContacto();
            footerModel.lstMenu = menuService.GetListFooterMenu();

            return footerModel;
        }

    }
}