using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Nuevo Milenio", 2000, TiposEscuela.Secundaria, pais: "Perú");
            escuela.Ciudad = "Trujillo";
            //escuela.Pais = "Perú";
            //escuela.TipoEscuela = TiposEscuela.Secundaria;
            Console.WriteLine(escuela);

            var curso1 = new Curso(){
                Nombre = "FUNPRO"
            };
            var curso2 = new Curso(){
                Nombre = "FUNAL"
            };
            var curso3 = new Curso(){
                Nombre = "ESTAD"
            };
            System.Console.WriteLine("====================================");
            System.Console.WriteLine($"Nombre: {curso1.Nombre} -> {curso1.UniqueId}");
            System.Console.WriteLine($"Nombre: {curso2.Nombre} -> {curso2.UniqueId}");
            System.Console.WriteLine($"Nombre: {curso3.Nombre} -> {curso3.UniqueId}");

        }
    }
}
