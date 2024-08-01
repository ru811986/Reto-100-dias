using System;

namespace ejemplo004
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            // Definición y uso de constantes

            const int VALOR = 5;

            const int VALOR2 = 7;

            Console.WriteLine("Los valores de las constantes son: {0} y {1}", VALOR, VALOR2);

            // Ejemplo práctico

            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            // double area = radio * radio * PI;
			
            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El área del círculo es: {area}");

        }
    }
}
