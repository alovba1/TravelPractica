namespace Travel.Domain.Model

{
    public class Libros
    {
        private string titulo = "";
        private string sinopsis = "";
        private string n_paginas= "";

        //public Guid ISBN { get; set; }
        public int Id { get; set; }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Sinopsis { get { return sinopsis; } set { sinopsis = value; } }
        public string N_paginas { get { return n_paginas; } set { n_paginas = value; } }
        
    }
}
