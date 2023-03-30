using System;
using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.Dtos;

namespace MarubeniCreditWeb.Data.Package.TipoCreditoPkg
{
    public class TipoCreditoService
    {
        public List<DetalleSeccion> GetListTipoCredito()
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {

                retorno = new List<DetalleSeccion>()
                {
                new DetalleSeccion() { titulo = "Auto", texto = "Conoce las alternabas  par financiar tu auto", btnTexto = "CONOCER MÁS", urlAction= "TipoCreditoAuto", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, imagen= "card-1.jpg" },
                new DetalleSeccion() { titulo = "Moto", texto = "Conoce las alternativas para financiar tu moto", btnTexto = "CONOCER MÁS", urlAction= "TipoCreditoMoto", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, imagen= "card-2.jpg" },
                new DetalleSeccion() { titulo = "Camión", texto = "Conoce las alternativas para financiar tu camión", btnTexto = "CONOCER MÁS", urlAction= "TipoCreditoCamion", urlController="TipoCredito", idTipoUrl = (int)Objeto.TipoUrl.urlVista, imagen= "card-3.jpg" },
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public DetalleSeccion GetEncabezado(int idTipoVehiculo)
        {
            DetalleSeccion retorno = new DetalleSeccion();

            try
            {
                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Auto)
                {

                    retorno = new DetalleSeccion()
                    {
                        titulo = "Financia tu automóvil nuevo o usado con Marubeni Credit",
                        texto = "Elije aquí el financiamiento que más se ajuste a su presupuesto y haga realidad el sueño del auto propio.",
                        imagen = "driver.jpg"
                    };
                }

                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Moto)
                {

                    retorno = new DetalleSeccion()
                    {
                        titulo = "Financia tu Motocicleta en Marubeni Credit",
                        texto = "Elije aquí el financiamiento que más se ajuste a su presupuesto y haga realidad esa inversión tan soñada.",
                        imagen = "moto.jpg"
                    };
                }


                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Camion)
                {

                    retorno = new DetalleSeccion()
                    {
                        titulo = "Financia tu camión en Marubeni Credit",
                        texto = "Elije aquí el financiamiento que más se ajuste a su presupuesto y haga realidad esa inversión.",
                        imagen = "camion.jpg"
                    };
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public DetalleSeccionLista GetTextoDestacado(int idTipoVehiculo)
        {
            DetalleSeccionLista retorno = new DetalleSeccionLista();

            try
            {
                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Auto)
                {
                    List<TextoSeccion> lstTexto = new List<TextoSeccion>() {
                    new TextoSeccion() { titulo ="RESPALDO:", texto ="Contamos con más de 40 años de experiencia en Chile con el respaldo de Marubeni Corporation Japón, compañía con más de 100 años haciendo negocios en los cinco continentes y con gran presencia en la industria automotriz a nivel mundial." },
                    new TextoSeccion() { titulo ="COMODIDAD:", texto ="Nos ocupamos de todos los detalles de su crédito.Encontrará respuestas claras y oportunas para que solo disfrute de su nuevo automóvil.Hará todos los tramites en un mismo lugar." },
                    new TextoSeccion() { titulo ="DEUDA NO INFORMADA:", texto ="No afecta su carga financiera." }
                    };

                    retorno = new DetalleSeccionLista()
                    {
                        titulo = "Por qué financiar con nosotros",
                        lstTexto = lstTexto
                    };
                }

                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Moto)
                {
                    List<TextoSeccion> lstTexto = new List<TextoSeccion>() {
                    new TextoSeccion() { titulo ="RESPALDO:", texto ="Contamos con más de 40 años de experiencia en Chile con el respaldo de Marubeni Corporation Japón, compañía con más de 100 años haciendo negocios en los cinco continentes y con gran presencia en la industria automotriz a nivel mundial." },
                    new TextoSeccion() { titulo ="COMODIDAD:", texto ="Nos ocupamos de todos los detalles de su crédito.Encontrará respuestas claras y oportunas para que solo disfrute de su nuevo automóvil.Hará todos los tramites en un mismo lugar." },
                    new TextoSeccion() { titulo ="DEUDA NO INFORMADA:", texto ="No afecta su carga financiera." }
                    };

                    retorno = new DetalleSeccionLista()
                    {
                        titulo = "Por qué financiar con nosotros",
                        lstTexto = lstTexto
                    };

                }

                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Camion)
                {
                    List<TextoSeccion> lstTexto = new List<TextoSeccion>() {
                    new TextoSeccion() { texto ="Somos especialistas en financiamiento automotriz. Contamos con más de 40 años de experiencia en Chile, con el respaldo de Marubeni Corporation Japón." }
                    };

                    retorno = new DetalleSeccionLista()
                    {
                        titulo = "Financiamiento Automotriz",
                        lstTexto = lstTexto
                    };
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<DetalleSeccion> GetListFinanciamiento(int idTipoVehiculo)
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {
                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Auto)
                {

                    retorno = new List<DetalleSeccion>()
                    {
                        new DetalleSeccion() { titulo = "Crédito Tradicional", texto = "Paga todos los meses la misma cuota fija en pesos.", descripcion="padding", btnTexto = "CONOCE MÁS", url = "#creditoT_auto", imagen = "driver-1.jpg", idTipoUrl = (int)Objeto.TipoUrl.modal },
                        new DetalleSeccion() { titulo = "Autoplan", texto = "Financiamiento que te permite pagar una cuota baja, y renovar tu automóvil cada 24 o 36 meses. Cuota fija en pesos.", btnTexto = "CONOCE MÁS", url = "#creditoAP_auto", imagen = "driver-2.jpg", idTipoUrl = (int)Objeto.TipoUrl.modal }
                    };
                }

                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Moto)
                {

                    retorno = new List<DetalleSeccion>()
                    {
                        new DetalleSeccion() { titulo = "Crédito Tradicional", texto = "Paga todos los meses la misma cuota fija en pesos.", descripcion="padding",  btnTexto = "CONOCE MÁS",  url = "#creditoT_moto", imagen = "moto-1.jpg", idTipoUrl = (int)Objeto.TipoUrl.modal },
                        new DetalleSeccion() { titulo = "Motoplan", texto = "Financiamiento que te permite pagar una cuota baja, y renovar tu automóvil cada 24 o 36 meses. Cuota fija en pesos.", btnTexto = "CONOCE MÁS",  url = "#creditoMP_moto", imagen = "moto-2.jpg", idTipoUrl = (int)Objeto.TipoUrl.modal }
                    };
                }


                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Camion)
                {

                    retorno = new List<DetalleSeccion>()
                    {
                        new DetalleSeccion() { titulo = "Crédito Tradicional", texto = "Paga todos los meses la misma cuota fija en pesos.", btnTexto = "CONOCE MÁS",  url = "#creditoT_camion", imagen = "camion-1.jpg", idTipoUrl = (int)Objeto.TipoUrl.modal }
                    };
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public List<DetalleSeccion> GetListOtroFinanciamiento(int idTipoVehiculo)
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {
                if (idTipoVehiculo == (int)Objeto.TipoVehiculo.Auto)
                {

                    retorno = new List<DetalleSeccion>()
                    {
                        new DetalleSeccion() { titulo = "Fast Credit", texto = "Crédito inmediato, para que adquiera el vehículo de su elección sin trámites y demoras.", descripcion="padding", btnTexto = "CONOCE MÁS",  url = "#creditoFC_auto", idTipoUrl = (int)Objeto.TipoUrl.modal },
                        new DetalleSeccion() { titulo = "Crédito Irregular", texto = "Un plan desarrollado para personas que mantienen ingresos variables. Acomoda tus cuotas a tus ingresos.", descripcion="padding", btnTexto = "CONOCE MÁS",  url = "#creditoIR_auto", idTipoUrl = (int)Objeto.TipoUrl.modal },
                        new DetalleSeccion() { titulo = "Autoplan Seminuevo", texto = "Financia tu seminuevo, pagando una una cuota baja, y renovar tu automóvil cada 24 o 36 meses. Cuota fija en pesos.", descripcion="padding", btnTexto = "CONOCE MÁS",  url = "#creditoASN_auto", idTipoUrl = (int)Objeto.TipoUrl.modal },
                        new DetalleSeccion() { titulo = "Plan Taxi", texto = "Si su vehículo es la herramienta de trabajo o necesita renovar o ampliar su flota este Crédito está pensado para usted.", btnTexto = "CONOCE MÁS",  url = "#creditoPT_auto", idTipoUrl = (int)Objeto.TipoUrl.modal }
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
