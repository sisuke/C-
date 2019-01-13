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
        }
    }
}
