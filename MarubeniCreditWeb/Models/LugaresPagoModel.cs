using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Dtos;
using MarubeniCreditWeb.Data.Package.LugaresPagoPkg;

namespace MarubeniCreditWeb.Models
{
    public class LugaresPagoModel
    {
        public DetalleSeccion formaPago { get; set; }
        public DetalleSeccionLista activaPAC { get; set; }
        public List<DetalleSeccion> lstLugaresPago { get; set; }

        public LugaresPagoModel GetLugaresPagoModel()
        {
            LugaresPagoModel lugaresPagoModel = new LugaresPagoModel();
            LugaresPagoService lugaresPagoService = new LugaresPagoService();

            lugaresPagoModel.formaPago = lugaresPagoService.GetFormaPago();
            lugaresPagoModel.activaPAC = lugaresPagoService.GetActivaPAC();
            lugaresPagoModel.lstLugaresPago = lugaresPagoService.GetListLugaresPago();

            return lugaresPagoModel;
        }
    }
}