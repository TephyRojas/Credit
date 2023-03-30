using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.RegionComunaPkg;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Models
{
    public class FormPortCertModel
    {
        public List<Certificado> lstCertificado { get; set; }
        public List<Region> lstRegion { get; set; }
        public List<Comuna> lstComuna { get; set; }
        public FormPortCertModel GetFormPortCertificado()
        {
            FormPortCertModel formPortCertModel = new FormPortCertModel();
            ServicioClienteService servicioClienteService = new ServicioClienteService();
            RegionComunaService regionComunaService = new RegionComunaService();
            List<Certificado> lstCertificado = servicioClienteService.GetListPortCertificados();
            List<Region> lstRegion = regionComunaService.GetListRegiones();
            List<Comuna> lstComuna = regionComunaService.GetListComunas(0);

            formPortCertModel.lstCertificado = lstCertificado;
            formPortCertModel.lstRegion = lstRegion;
            formPortCertModel.lstComuna = lstComuna;

            return formPortCertModel;
        }

    }
}