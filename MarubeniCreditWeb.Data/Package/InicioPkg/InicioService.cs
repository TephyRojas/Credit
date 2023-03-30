using System;
using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Comun;
using MarubeniCreditWeb.Data.Package.Dtos;

namespace MarubeniCreditWeb.Data.Package.InicioPkg
{
    public class InicioService
    {
        public List<DetalleSeccion> GetListCarrete()
        {
            List<DetalleSeccion> retorno = new List<DetalleSeccion>();

            try
            {

                retorno = new List<DetalleSeccion>()
                {
                new DetalleSeccion() { texto = "Financiamos la vida en familia", btnTexto = "Enviar 1", url= "", imagen= "carrusel_home_1.jpg" },
                new DetalleSeccion() { texto = "Financiamos tu aventura", btnTexto = "Enviar 1", url= "", imagen= "carrusel_home_2.jpeg" },
                new DetalleSeccion() { texto = "Ayudamos a hacer crecer tu negocio", btnTexto = "Enviar 1", url= "", imagen= "carrusel_home_3.jpeg" },
                new DetalleSeccion() { texto = "Evita Fraudes", btnTexto = "Enviar 1", url= "", imagen= "carrusel_home_4.jpeg" }
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }


        public DetalleSeccion GetTextoDestacado()
        {
            DetalleSeccion retorno = new DetalleSeccion();

            try
            {

                retorno = new DetalleSeccion()
                {
                    titulo = "Quiénes Somos",
                    texto = "Somos una empresa que nace hace más de 40 años, para entregar soluciones financieras automotrices a la medida de sus clientes.\n\n" +
                "La calidad de servicio, experiencia, confianza y gran respaldo de Marubeni el mundo, son los pilares de Marubeni Credit que busca desarrollar procesos que permitan" +
                " el acceso fácil, ágil y transparente a la hora de financiar un vehí­culo. El compromiso de calidad y servicio que asumimos con nuestros clientes," +
                "nos mueve a seguir avanzando en la búsqueda de mejoras continuas e innovación que permite otorgar un servicio de excelencia y nos posiciona como una Compañía " +
                "lí­der en el mercado de financiamiento automotriz.",
                    btnTexto = "VER MÁS",
                    urlAction = "NuestraEmpresa",
                    urlController = "Home"
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public DetalleSeccion GetSimulaFinanciamiento()
        {
            DetalleSeccion retorno = new DetalleSeccion();

            try
            {

                retorno = new DetalleSeccion()
                {
                    titulo = "¿Quieres conocer tu cuota?",
                    texto = "Simula tu financiamiento",
                    btnTexto = "SIMULAR FINANCIAMIENTO",
                    url = "",
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

            return retorno;
        }

        public DetalleSeccion GetPagoOnline()
        {
            DetalleSeccion retorno = new DetalleSeccion();

            try
            {

                retorno = new DetalleSeccion()
                {
                    titulo = "Mantén tus cuotas al día pagando online de manera rápida y segura",
                    texto = "",
                    btnTexto = "PAGAR ONLINE",
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
    }
}
