using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Dtos;
using MarubeniCreditWeb.Data.Package.InicioPkg;
using MarubeniCreditWeb.Data.Package.TipoCreditoPkg;


namespace MarubeniCreditWeb.Models
{
    public class InicioModel
    {
        public List<DetalleSeccion> lstCarrete { get; set; }
        public DetalleSeccion textoDestacado { get; set; }
        public List<DetalleSeccion> lstFinanciamiento { get; set; }
        public DetalleSeccion simulaFinanciamiento { get; set; }
        public DetalleSeccion pagoOnline { get; set; }

        public InicioModel GetInicioModel()
        {
            InicioModel inicioModel = new InicioModel();
            InicioService inicioService = new InicioService();
            TipoCreditoService tipoCreditoService = new TipoCreditoService();

            inicioModel.lstCarrete = inicioService.GetListCarrete();
            inicioModel.textoDestacado = inicioService.GetTextoDestacado();
            inicioModel.lstFinanciamiento = tipoCreditoService.GetListTipoCredito();
            inicioModel.simulaFinanciamiento = inicioService.GetSimulaFinanciamiento();
            inicioModel.pagoOnline = inicioService.GetPagoOnline();

            return inicioModel;
        }
    }
}