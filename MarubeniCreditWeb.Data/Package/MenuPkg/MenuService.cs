using System;
using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;

namespace MarubeniCreditWeb.Data.Package.MenuPkg
{
    public class MenuService
    {
        public List<Menu> GetListTopBar()
        {
            List<Menu> retorno = new List<Menu>();

            try
            {

                retorno = new List<Menu>()
                {
                new Menu() { imagen =  "mh-1.svg", titulo = "Actualiza tus datos", url= "", urlAction= "MostrarFormActDatos", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.modal },
                new Menu() { imagen =  "mh-2.svg", titulo = "Servicio al cliente", url="", urlAction= "ServicioCliente", urlController="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public Menu GetFooterLogo()
        {
            Menu retorno = new Menu();

            try
            {

                retorno = new Menu()
                {
                    imagen = "logo-footer.png",
                    idMenu = (int)Objeto.Menu.footer,
                    idTipoMenu = (int)Objeto.TipoMenu.imagen
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<Menu> GetListFooterSucursales()
        {
            List<Menu> retorno = new List<Menu>();

            try
            {

                retorno = new List<Menu>()
                {
                new Menu() { titulo = "Sucursales Marubeni", subtitulo = "Avenida Vicuña Mackenna N° 3300, Macul, Santiago" },
                new Menu() { titulo = "Sucursales Marubeni", subtitulo = "Pedro Aguirre Cerda 7903, Antofagasta" },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public Menu GetFooterContacto()
        {
            Menu retorno = new Menu();

            try
            {

                retorno = new Menu()
                {
                    titulo = "CONTACTANOS",
                    subtitulo = "+56 2 2680 3370",
                    url = ""
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }
        public List<Menu> GetListFooterMenu()
        {
            List<Menu> retorno = new List<Menu>();

            try
            {

                retorno = new List<Menu>()
                {
                new Menu() { titulo = "Menú", subtitulo = "Lugares de Pago", urlAction= "LugaresPago", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                new Menu() { titulo = "Menú", subtitulo = "Nuestra Empresa", urlAction= "NuestraEmpresa", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista},
                new Menu() { titulo = "Menú", subtitulo = "Tipos de créditos", urlAction= "Index", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVistaHashtag },
                new Menu() { titulo = "Menú", subtitulo = "Paga tu cuota", url = "https://botondepago.marubenicredit.cl/login.aspx", idTipoUrl = (int)Objeto.TipoUrl.url },
                //new Menu() { titulo = "Menú", subtitulo = "Simula aquí", urlAction= "Simulador", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista}
                new Menu() { titulo = "Menú", subtitulo = "Servicio al Cliente", urlAction= "ServicioCliente", urlController="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista },
                new Menu() { titulo = "Menú", subtitulo = "Preguntas Frecuentes",urlAction= "ServicioCliente", urlController ="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista},
                //new Menu() { titulo = "Menú", subtitulo = "Términos y condiciones", url= "#modalTC", idTipoUrl = (int)Objeto.TipoUrl.modal },
                //new Menu() { titulo = "Menú", subtitulo = "Condiciones objetivas créditos", url= "#modalCO", idTipoUrl = (int)Objeto.TipoUrl.modal },
                //new Menu() { titulo = "Menú", subtitulo = "Términos y condiciones simulador", url= "#modalTCS", idTipoUrl = (int)Objeto.TipoUrl.modal },

                new Menu() { titulo = "Menú", subtitulo = "Términos y condiciones", urlAction= "TerminosCondiciones", urlController="Terminos", idTipoUrl = (int)Objeto.TipoUrl.urlVistaTerm },
                new Menu() { titulo = "Menú", subtitulo = "Condiciones objetivas créditos", urlAction= "TermCondCreditos", urlController="Terminos", idTipoUrl = (int)Objeto.TipoUrl.urlVistaTerm},
                new Menu() { titulo = "Menú", subtitulo = "Términos y condiciones simulador", urlAction= "TermCondSimulador", urlController="Terminos", idTipoUrl = (int)Objeto.TipoUrl.urlVistaTerm },


                new Menu() { titulo = "Menú", subtitulo = "Trabaja con Nosotros", urlAction= "TrabajaConNosotros", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista},
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<Menu> GetListNavBarMenu()
        {
            List<Menu> retorno = new List<Menu>();

            try
            {

                retorno = new List<Menu>()
                {
                new Menu() { titulo = "Lugares de Pago", urlAction= "LugaresPago", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 1 },
                new Menu() { titulo = "Nuestra empresa", urlAction= "NuestraEmpresa", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 2 },
                new Menu() { titulo = "Tipos de créditos", url= "", idTipoUrl = (int)Objeto.TipoUrl.url, idTipoMenu = (int)Objeto.TipoMenu.listaDespegable, orden = 3 },
                //new Menu() { titulo = "Trabaja con Nosotros", urlAction= "TrabajaConNosotros", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 4 },
                new Menu() { titulo = "Contáctenos", urlAction= "ServicioCliente", urlController="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 4 },
                //new Menu() { titulo = "Simula Aquí", subtitulo = "", urlAction= "Simulador", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.botonSecundario },
                //new Menu() { titulo = "Paga tu Cuota", subtitulo = "", url= "", idTipoUrl = (int)Objeto.TipoUrl.url, idTipoMenu = (int)Objeto.TipoMenu.botonPrimario },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<Menu> GetListNavBarMobile()
        {
            List<Menu> retorno = new List<Menu>();

            try
            {

                retorno = new List<Menu>()
                {
                new Menu() { titulo = "Lugares de Pago", urlAction= "LugaresPago", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 3 },
                new Menu() { titulo = "Nuestra empresa", urlAction= "NuestraEmpresa", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 4 },
                new Menu() { titulo = "Tipos de créditos", url= "", idTipoUrl = (int)Objeto.TipoUrl.url, idTipoMenu = (int)Objeto.TipoMenu.listaDespegable, orden = 5 },
                //new Menu() { titulo = "Trabaja con Nosotros", urlAction= "TrabajaConNosotros", urlController="Home", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 5 },
                new Menu() { titulo = "Contáctenos", urlAction= "ServicioCliente", urlController="ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 5 },
                new Menu() { titulo = "Actualiza tus datos", url = "", urlAction = "MostrarFormActDatos", urlController = "Home", idTipoUrl = (int)Objeto.TipoUrl.modal, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 5  },
                new Menu() { titulo = "Servicio al cliente", url = "", urlAction = "ServicioCliente", urlController = "ServicioCliente", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto, orden = 5  },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }


        public Menu GetNavBarBoton(int boton)
        {
            Menu retorno = new Menu();

            try
            {
                if (boton == (int)Objeto.Boton.Secundario)
                {
                    retorno = new Menu()
                    {
                        titulo = "Simula Aquí",
                        subtitulo = "",
                        urlAction = "Simulador",
                        urlController = "Home",
                        idTipoUrl = (int)Objeto.TipoUrl.urlVista,
                        idTipoMenu = (int)Objeto.TipoMenu.botonSecundario
                    };
                }

                if (boton == (int)Objeto.Boton.Primario)
                {
                    retorno = new Menu()
                    {
                        titulo = "Paga tu Cuota",
                        subtitulo = "",
                        url = "https://botondepago.marubenicredit.cl/login.aspx",
                        idTipoUrl = (int)Objeto.TipoUrl.url,
                        idTipoMenu = (int)Objeto.TipoMenu.botonPrimario
                    };
                }



            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }
        public List<SubMenu> GetListNavBarSubMenu()
        {
            List<SubMenu> retorno = new List<SubMenu>();

            try
            {

                retorno = new List<SubMenu>()
                {
                new SubMenu() { tituloMenu = "Tipos de créditos", tituloSubMenu = "Créditos Auto", urlAction= "TipoCreditoAuto", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto },
                new SubMenu() { tituloMenu = "Tipos de créditos", tituloSubMenu = "Créditos Moto", urlAction= "TipoCreditoMoto", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto },
                new SubMenu() { tituloMenu = "Tipos de créditos", tituloSubMenu = "Créditos Camión", urlAction= "TipoCreditoCamion", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, idTipoMenu = (int)Objeto.TipoMenu.texto },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }
    }
}
