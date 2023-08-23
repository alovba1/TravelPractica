namespace Travel.Domain.Model

{
    public class Persona
    {
        
        private string tipoIdentificacion = null;
        private string nroIdentificacion = null;
        private string primerNombre = null;
        private string segundoNombre = null;
        private string primerApellido = null;
        private string segundoApellido = null;
        private string sexo = null;
        private DateTime fechaNacimiento;
        private string codMpioResidencia = null;
        private string codAsegurador = null;
        private DateTime fechaRegistro;


        public int Id { get; set; }

        public string TipoIdentificacion { get { return tipoIdentificacion; } set { tipoIdentificacion = value; } }
        public string NroIdentificacion { get { return nroIdentificacion; } set { nroIdentificacion = value; } }
        public string PrimerNombre { get { return primerNombre; } set { primerNombre = value; } }
        public string SegundoNombre { get { return segundoNombre; } set { segundoNombre = value; } }
        public string PrimerApellido { get { return primerApellido; } set { primerApellido = value; } }
        public string SegundoApellido { get { return segundoApellido; } set { segundoApellido = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public string CodAsegurador { get { return codAsegurador; } set { codAsegurador = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public string CodMpioResidencia { get { return codMpioResidencia; } set { codMpioResidencia = value; } }
        public DateTime FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }

    }
}
