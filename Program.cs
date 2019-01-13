using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Nuevo Milenio", 2000, TiposEscuela.Secundaria, pais: "Perú");
            var cursos = new Curso[3];

            escuela.Ciudad = "Trujillo";
            //escuela.Pais = "Perú";
            //escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);


            cursos[0] = new Curso(){
                Nombre = "FUNPRO"
            };
            cursos[1] = new Curso(){
                Nombre = "FUNAL"
            };
            var curso3 = new Curso(){
                Nombre = "ESTAD"
            };

            cursos[2] = curso3;

            System.Console.WriteLine("====================================");
            System.Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            
            ImprimirCursos(cursos);

        }

        private static void ImprimirCursos(Curso[] cursos)
        {
            foreach (var item in cursos){
                Console.WriteLine($"Nombre: {item.Nombre}, Id: {item.UniqueId}");
            }
        }
    }
}
