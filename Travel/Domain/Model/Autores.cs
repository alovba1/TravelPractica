namespace Travel.Domain.Model
{
    public class Autores
    {
        private string nombre = "";
        private string apellido = "";
        public int Id { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        

    }
}
