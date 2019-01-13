namespace CoreEscuela.Entidades{
    class Escuela{
        string nombre;

        public string Nombre{
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int añoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        /* public Escuela(string nombre, int añoDeCreacion){
           this.nombre = nombre;
           this.añoDeCreacion = añoDeCreacion;
        }*/

       public Escuela(string nombre, int añoDeCreacion) => (this.nombre,this.añoDeCreacion) = (nombre,añoDeCreacion);
    }
}