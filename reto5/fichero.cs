using System;

namespace ejemplo005
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            saludarse("Rubén");
            int edad1 = pedirEdad("Introduzca la edad de la persona 1");
            int edad2 = pedirEdad("Introduzca la edad de la persona 2");
            double mediaDeDosEdades = hallarMedia(edad1, edad2);
            Console.WriteLine($"Media de las edades {edad1} y {edad2}: {mediaDeDosEdades}");
            int indice = pedirIndice("Introduzca hasta que índice quiere ver de la serie Fibonacci");
            extraerSerieFibonacciHasta(indice);
            despedirse("Rubén");
        }

        // Funciones de saludarse y de despedirse

        public static void saludarse(string nombre)
        {
            Console.WriteLine($"¡Buenas {nombre}!");
        }

        public static void despedirse(string nombre)
        {
            Console.WriteLine($"¡Hasta luego {nombre}!");
        }

        // Función que retorna la media de dos edades

        public static int pedirEdad(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        public static double hallarMedia(int edad1, int edad2)
        {
            return (edad1 + edad2) / 2.0;
        }

        // Función que extraiga la serie de Fibonacci hasta el índice indicado

        public static int pedirIndice(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        public static void extraerSerieFibonacciHasta(int indice)
        {
            int valor1 = 1;
            int valor2 = 1;
            for (int i = 1; i <= indice; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(valor1);
                } else if (i == 2)
                {
                    Console.WriteLine(valor2);
                } else
                {
                    int aux = valor1;
                    valor1 = valor2;
                    valor2 = aux + valor1;
                    Console.WriteLine(valor2);
                }
            }
        }
    }
}
