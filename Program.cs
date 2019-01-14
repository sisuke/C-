using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;
namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Nuevo Milenio", 2000, TiposEscuela.Secundaria, pais: "Perú");

            escuela.Cursos = new List<Curso>{
                new Curso(){ Nombre = "FUNPRO", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "FUNAL", Jornada = TiposJornada.Noche },
                new Curso(){ Nombre = "ESTAD", Jornada = TiposJornada.Mañana }
            };

            escuela.Cursos.Add(new Curso() { Nombre = "MOANSO", Jornada = TiposJornada.Tarde} );
            escuela.Cursos.Add(new Curso() { Nombre = "TECPRO", Jornada = TiposJornada.Noche} );

            var otraColeccion = new List<Curso>{
                new Curso(){ Nombre = "TECPRO", Jornada = TiposJornada.Mañana },
                new Curso(){ Nombre = "INISCO", Jornada = TiposJornada.Noche },
                new Curso{ Nombre = "DIARS", Jornada = TiposJornada.Mañana }
            };

            Curso tmp = new Curso{ Nombre = "MATE", Jornada = TiposJornada.Mañana };
            escuela.Cursos.AddRange(otraColeccion);
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            otraColeccion.Clear();
            WriteLine("Curso.Hash: " + tmp.GetHashCode());
            escuela.Cursos.Remove(tmp);

            Predicate<Curso> miAlgoritmo = Predicate;

            //escuela.Cursos.RemoveAll(Predicate);

            /*escuela.Cursos.RemoveAll(delegate (Curso curso){
                return curso.Nombre == "TECPRO";
            });*/

            escuela.Cursos.RemoveAll((curso) => curso.Nombre == "TECPRO" && curso.Jornada == TiposJornada.Noche);







            WriteLine($"Contador: {escuela.Cursos.Count}");
            WriteLine("===================================");

            /* Curso [] cursos = new Curso[3]{
                new Curso(){ Nombre = "FUNPRO" },
                new Curso(){ Nombre = "FUNAL" },
                new Curso(){ Nombre = "ESTAD" }
            };*/

            //escuela.Cursos = cursos;

            /*cursos = new Curso[]{
                new Curso(){ Nombre = "FUNPRO" },
                new Curso(){ Nombre = "FUNAL" },
                new Curso{ Nombre = "ESTAD" }
            };*/

            /*Curso [] cursosX = {
                new Curso(){ Nombre = "FUNPRO" },
                new Curso(){ Nombre = "FUNAL" },
                new Curso(){ Nombre = "ESTAD" }
            };*/

            escuela.Ciudad = "Trujillo";
            //escuela.Pais = "Perú";
            //escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);


            /* cursos[0] = new Curso()
            {
                Nombre = "FUNPRO"
            };
            cursos[1] = new Curso()
            {
                Nombre = "FUNAL"
            };
            var curso3 = new Curso()
            {
                Nombre = "ESTAD"
            };

            cursos[2] = curso3;*/

            WriteLine("====================================");
            WriteLine("Presione ENTER para continuar");
            WriteLine("====================================");
            Console.ReadLine();

            //escuela = null;

            //ImprimirCursosForeach(cursos);
            ImprimirCursosEscuela(escuela);

        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "TECPRO";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=============================");
            WriteLine("==== Curso de la Escuela ====");
            WriteLine("=============================");

            if(escuela?.Cursos == null) return;

            foreach (var curso in escuela.Cursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId}");
            }
        }

        private static void ImprimirCursosForeach(Curso[] cursos)
        {
            foreach (var item in cursos)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            }
        }
    }
}
