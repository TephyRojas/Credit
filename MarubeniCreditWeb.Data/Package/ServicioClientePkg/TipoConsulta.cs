using System.ComponentModel.DataAnnotations;

namespace MarubeniCreditWeb.Data.Package.ServicioClientePkg
{
    public class TipoConsulta
    {
        const int strMax = 100;
        [StringLength(maximumLength: strMax)]
        public string tipoConsulta { get; set; }
        public string emailDeriv { get; set; }
        public int orden { get; set; }
        public bool check { get; set; } = false;
    }
}
