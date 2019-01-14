namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int añoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        /* public Escuela(string nombre, int añoDeCreacion){
           this.nombre = nombre;
           this.añoDeCreacion = añoDeCreacion;
        }*/
        public Curso[] Cursos { get; set; }

        public Escuela(string nombre, int añoDeCreacion) => (this.nombre, this.añoDeCreacion) = (nombre, añoDeCreacion);

        public Escuela(string nombre, int añoDeCreacion, TiposEscuela tipoEscuela, string pais = "", string ciudad = "")
        {
            (this.nombre, this.añoDeCreacion) = (nombre, añoDeCreacion);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            string newLine = System.Environment.NewLine;
            return $" Nombre: \"{Nombre}\" {newLine} Tipo: {TipoEscuela} \n Año de creación: {añoDeCreacion} \n Ciudad: {Ciudad} \n País: {Pais} \n";
        }
    }
}