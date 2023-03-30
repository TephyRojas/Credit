using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Dtos;
using MarubeniCreditWeb.Data.Package.TipoCreditoPkg;

namespace MarubeniCreditWeb.Models
{
    public class TipoCreditoModel
    {
        public DetalleSeccion encabezado { get; set; }
        public DetalleSeccionLista textoDestacado { get; set; }
        public List<DetalleSeccion> lstFinanciamiento { get; set; }
        public List<DetalleSeccion> lstOtroFinanciamiento { get; set; }

        public TipoCreditoModel GetTipoCreditoModel(int idTipoVehiculo)
        {
            TipoCreditoModel tipoCreditoModel = new TipoCreditoModel();
            TipoCreditoService tipoCreditoService = new TipoCreditoService();

            tipoCreditoModel.encabezado = tipoCreditoService.GetEncabezado(idTipoVehiculo);
            tipoCreditoModel.textoDestacado = tipoCreditoService.GetTextoDestacado(idTipoVehiculo);
            tipoCreditoModel.lstFinanciamiento = tipoCreditoService.GetListFinanciamiento(idTipoVehiculo);
            tipoCreditoModel.lstOtroFinanciamiento = tipoCreditoService.GetListOtroFinanciamiento(idTipoVehiculo);

            return tipoCreditoModel;
        }
    }
}