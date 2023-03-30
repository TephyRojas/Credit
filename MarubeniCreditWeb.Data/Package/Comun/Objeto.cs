namespace MarubeniCreditWeb.Data.Package.Comun
{
    public class Objeto
    {
        public enum TipoUrl
        {
            modal = 1,
            url = 2,
            urlVista = 3,
            urldestacada = 4,
            urlVistaHashtag= 5,
            urlVistaTerm = 6

        }

        public enum Menu
        {
            topBar = 1,
            navBar = 2,
            footer = 3

        }
        public enum TipoMenu
        {
            texto = 1,
            imagen = 2,
            boton = 3,
            botonPrimario = 4,
            botonSecundario = 5,
            listaDespegable = 6
        }

        public enum Seccion
        {
            homeCarrete = 1,
            homeTextoDestacado = 2,
            homeTipoCredito = 3,
            homeSimulaFinaciamiento = 4,
            homePagoOnline = 5

        }

        public enum Archivos
        {
            Formulario_Servicio_al_Cliente = 1,
            Formulario_Portabilidad = 2,

        }

        public enum TipoVehiculo
        {
            Auto = 1,
            Moto = 2,
            Camion = 3

        }

        public enum Formulario
        {
            Contacto = 1,
            Certificado = 2,
            PortSolicitud = 3,
            PortCertificado = 4,
            ActualizaDatos = 5,
            TrabajaConNosotros = 6
        }

        public enum Boton
        {
            Primario = 1,
            Secundario = 2
        }

        public enum TipoCredito
        {
            Tradicional = 1,
            Autoplan = 2,
            FastCredit = 3,
            Irregular = 4,
            AutoplanSemi = 5,
            Taxi = 6,
            MotoTradicional = 7,
            Motoplan = 8,
            Camion = 9
        }
    }


}
