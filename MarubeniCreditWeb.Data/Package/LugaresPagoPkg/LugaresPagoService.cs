using System;
using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.Dtos;

namespace MarubeniCreditWeb.Data.Package.LugaresPagoPkg
{
    public class LugaresPagoService
    {
        public DetalleSeccion GetFormaPago()
        {
            DetalleSeccion retorno = new DetalleSeccion();

            try
            {

                retorno = new DetalleSeccion()
                {
                    titulo = "Mantén tus cuotas al día pagando online de manera rápida y segura",
                    texto = "PAGA DE FORMA SEGURA Y FÁCIL",
                    btnTexto = "PAGAR EN MARUBENICREDIT",
                    url = "https://botondepago.marubenicredit.cl/login.aspx",
                    idTipoUrl = (int)Objeto.TipoUrl.url
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public DetalleSeccionLista GetActivaPAC()
        {
            DetalleSeccionLista retorno = new DetalleSeccionLista();

            try
            {
                List<TextoSeccion> lstTexto = new List<TextoSeccion>() {
                new TextoSeccion() { texto = "No hagas más filas para pagar!" },
                new TextoSeccion() { texto = "Es gratuito, sólo tienes que mantener el saldo suficiente en tu cuenta, antes de la fecha de vencimiento que tengas." },
                new TextoSeccion() { texto = "Con PAC evitas atrasos en los pagos." },
                new TextoSeccion() { texto = "Al pagar al día, evitas pagos de interés." }
                };

                retorno = new DetalleSeccionLista()
                {
                    titulo = "Inscribe tu cuota al PAC",
                    lstTexto = lstTexto,
                    btnTexto = "ACTIVA TU PAC",
                    icono = "red-check.svg",
                    url = "",
                    idTipoUrl = (int)Objeto.TipoUrl.url
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<DetalleSeccion> GetListLugaresPago()
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {

                retorno = new List<DetalleSeccion>()
                {
                new DetalleSeccion() { texto = "Paga tus cuotas online a través de ", titulo ="SERVIPAG", btnTexto = "Pagar en SERVIPAG", url= "https://portal.servipag.com/", idTipoUrl = (int)Objeto.TipoUrl.url },
                new DetalleSeccion() { texto = "Paga tus cuotas online a través de ", titulo ="UNIRED", btnTexto = "Pagar en UNIRED", url= "https://www.unired.cl/ ", idTipoUrl = (int)Objeto.TipoUrl.url },
                new DetalleSeccion() { texto = "Paga tus cuotas presenciales en ", titulo ="Banco BCI", btnTexto = "Sucursales Banco BCI", url= "https://www.bci.cl/corporativo/sucursales-y-cajeros ", idTipoUrl = (int)Objeto.TipoUrl.url },
                new DetalleSeccion() { texto = "Paga tus cuotas presenciales en ", titulo ="Banco de Chile", btnTexto = "Sucursales Banco de Chile", url= "https://portales.bancochile.cl/personas/sucursales ", idTipoUrl = (int)Objeto.TipoUrl.url }
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
