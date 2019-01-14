using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
            Printer.Beep();
            Printer.Beep(10000,tiempo:10);

        }

        private static bool Predicate(Curso obj)
        {
            return obj.Nombre == "TECPRO";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

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
