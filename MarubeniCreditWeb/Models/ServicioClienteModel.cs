using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.Dtos;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Models
{
    public class ServicioClienteModel
    {
        public List<PregutaFrecuente> lstPregutaFrecuente { get; set; }
        public List<DetalleSeccion> lstOtrosDocs { get; set; }

        public ServicioClienteModel GetServicioCliente()
        {
            ServicioClienteModel servicioClienteModel = new ServicioClienteModel();
            ServicioClienteService servicioClienteService = new ServicioClienteService();
            servicioClienteModel.lstPregutaFrecuente = servicioClienteService.GetListPregFrecuentes();
            servicioClienteModel.lstOtrosDocs = servicioClienteService.GetListOtrosDocs();

            return servicioClienteModel;
        }

    }
}