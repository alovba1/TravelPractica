namespace Atencion.Domain.Model
{
    public class Seguimiento
    {
        private string estadoVital = null;
        private int idPersona = 0;
        private DateTime fechaDefuncion;
        private string ubicacionDefuncion = null;
        private string codLugarAtencion = null;
        private DateTime fechaAtencion;
        private int pesoKg = 0;
        private int tallaCm = 0;
        private string  codClasificacionNutricional = null;
        private string codManejoActual = null;
        private string desManejo = null;
        private string codUbicacion = null;
        private string desUbicacion = null;
        private string codTratamiento = null;
        private int totalSobreFTLC = 0;
        private string otroTratamiento = null;
        private DateTime fechaRegistro;
        public int Id { get; set; }
        public string EstadoVital { get { return estadoVital; } set { estadoVital = value; } }
        public int IdPersona { get { return idPersona; } set { idPersona = value; } }
        public DateTime FechaDefuncion { get { return fechaDefuncion; } set { fechaDefuncion = value; } }
        public string UbicacionDefuncion { get { return ubicacionDefuncion; } set { ubicacionDefuncion = value; } }
        public string CodLugarAtencion { get { return codLugarAtencion; } set { codLugarAtencion = value; } }
        public DateTime FechaAtencion { get { return fechaAtencion; } set { fechaAtencion = value; } }
        public int PesoKg { get { return pesoKg; } set { pesoKg = value; } }
        public string CodClasificacionNutricional { get { return codClasificacionNutricional; } set { codClasificacionNutricional = value; } }
        public int TallaCm { get { return tallaCm; } set { tallaCm = value; } }
        public string CodManejoActual { get { return codManejoActual; } set { codManejoActual = value; } }
        public string DesManejo { get { return desManejo; } set { desManejo = value; } }
        public string CodUbicacion { get { return codUbicacion; } set { codUbicacion = value; } }
        public string DesUbicacion { get { return desUbicacion; } set { desUbicacion = value; } }
        public string CodTratamiento { get { return codTratamiento; } set { codTratamiento = value; } }
        public int TotalSobreFTLC { get { return totalSobreFTLC; } set { totalSobreFTLC = value; } }
        public string OtroTratamiento { get { return otroTratamiento; } set { otroTratamiento = value; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
    }
    }