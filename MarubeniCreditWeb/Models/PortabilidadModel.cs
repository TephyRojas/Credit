using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Models
{
    public class PortabilidadModel
    {
        public List<PregutaFrecuente> lstPregutaFrecuente { get; set; }

        public PortabilidadModel GetPortabilidad()
        {
            PortabilidadModel portabilidadModel = new PortabilidadModel();
            ServicioClienteService servicioClienteService = new ServicioClienteService();
            portabilidadModel.lstPregutaFrecuente = servicioClienteService.GetListPregFrecuentesPort();

            return portabilidadModel;
        }

    }
}