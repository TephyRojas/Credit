using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.RegionComunaPkg;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Models
{
    public class FormContactoModel
    {
        public List<TipoConsulta> lstTipoConsulta { get; set; }
        public List<Region> lstRegion { get; set; }
        public List<Comuna> lstComuna { get; set; }

        public FormContactoModel GetFormContacto(int check = 0)
        {
            FormContactoModel formContactoModel = new FormContactoModel();
            ServicioClienteService servicioClienteService = new ServicioClienteService();
            RegionComunaService regionComunaService = new RegionComunaService();
            List<TipoConsulta> lstTipoConsulta = servicioClienteService.GetListTipoConsulta(check);
            List<Region> lstRegion = regionComunaService.GetListRegiones();
            List<Comuna> lstComuna = regionComunaService.GetListComunas(0);

            formContactoModel.lstTipoConsulta = lstTipoConsulta;
            formContactoModel.lstRegion = lstRegion;
            formContactoModel.lstComuna = lstComuna;

            
            return formContactoModel;

        }
    }

}