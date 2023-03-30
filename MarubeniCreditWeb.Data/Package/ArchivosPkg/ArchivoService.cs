using System;
using System.Collections.Generic;

namespace MarubeniCreditWeb.Data.Package.ArchivosPkg
{
    public class ArchivoService
    {
        public List<ArchivoDescargable> GetListArchivos()
        {
            List<ArchivoDescargable> retorno = null;

            try
            {

                retorno = new List<ArchivoDescargable>()
                {
                new ArchivoDescargable() { codigo = 1, nombre = "formulario solicitud certificado", extension = ".pdf" },
                new ArchivoDescargable() { codigo = 2, nombre = "formulario portabilidad", extension = ".pdf" }
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
