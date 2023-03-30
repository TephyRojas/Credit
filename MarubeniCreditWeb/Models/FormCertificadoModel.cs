using System.Collections.Generic;
using MarubeniCreditWeb.Data.Package.RegionComunaPkg;
using MarubeniCreditWeb.Data.Package.ServicioClientePkg;

namespace MarubeniCreditWeb.Models
{
    public class FormCertificadoModel
    {
        public List<Certificado> lstCertificado { get; set; }
        public List<Region> lstRegion { get; set; }
        public List<Comuna> lstComuna { get; set; }
        public FormCertificadoModel GetFormCertificado()
        {
            FormCertificadoModel formCertificadoModel = new FormCertificadoModel();
            ServicioClienteService servicioClienteService = new ServicioClienteService();
            RegionComunaService regionComunaService = new RegionComunaService();
            List<Certificado> lstCertificado = servicioClienteService.GetListCertificados();
            List<Region> lstRegion = regionComunaService.GetListRegiones();
            List<Comuna> lstComuna = regionComunaService.GetListComunas(0);

            formCertificadoModel.lstCertificado = lstCertificado;
            formCertificadoModel.lstRegion = lstRegion;
            formCertificadoModel.lstComuna = lstComuna;

            return formCertificadoModel;
        }

        



    }
}