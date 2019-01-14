using System;
using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int length = 10)
        {
            WriteLine("".PadLeft(length, '='));
        }

        public static void WriteTitle(string texto)
        {
            var size = texto.Length + 4;
            DibujarLinea(size);
            WriteLine($"| {texto} |");
            DibujarLinea(size);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad-- > 0){
                System.Console.Beep(hz,tiempo);
            }
        }

    }
}