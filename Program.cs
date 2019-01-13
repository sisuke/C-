using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Nuevo Milenio", 2000);
            Console.WriteLine(escuela.Nombre);
        }
    }
}
