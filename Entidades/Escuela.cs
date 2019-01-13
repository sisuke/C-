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

        public TiposEscuela TipoEscuela { get; set; }

        /* public Escuela(string nombre, int añoDeCreacion){
           this.nombre = nombre;
           this.añoDeCreacion = añoDeCreacion;
        }*/

       public Escuela(string nombre, int añoDeCreacion) => (this.nombre,this.añoDeCreacion) = (nombre,añoDeCreacion);

       public override string ToString(){
           return $" Nombre: {Nombre} \n Tipo: {TipoEscuela} \n Año de creación: {añoDeCreacion} \n Ciudad: {Ciudad} \n País: {Pais} \n";
       }
    }
}