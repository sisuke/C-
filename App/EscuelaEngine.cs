using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Nuevo Milenio", 2000, TiposEscuela.Secundaria, pais: "Perú");
            CargarCurso();

        }

        private void CargarCurso()
        {
            Escuela.Cursos = new List<Curso>{
                new Curso(){ Nombre = "FUNPRO", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "FUNAL", Jornada = TiposJornada.Noche },
                new Curso(){ Nombre = "ESTAD", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "INISCO", Jornada = TiposJornada.Noche },
                new Curso{ Nombre = "DIARS", Jornada = TiposJornada.Mañana }
            };
        }
    }
}