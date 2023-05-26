namespace Travel.Domain.Model
{
    public class Editoriales
    {
        private string nombre = "";
        private string sede = "";
        public int Id { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Sede { get { return sede; } set { sede = value; } }
    }
}
