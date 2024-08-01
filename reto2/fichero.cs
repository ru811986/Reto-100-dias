using System;

namespace ejemplo002
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de C#");  // Esto imprime un mensaje en consola

            int edad = 19;

            Console.WriteLine("Tienes una edad de " + edad + " años");
            Console.WriteLine($"Tienes una edad de {edad} años"); // Interpolación de strings
        }
    }
}
