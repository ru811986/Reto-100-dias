using System;

namespace ejemplo003
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            // Declaración explícita de variables

            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona1);

            // Declaración implícita de variables

            var edadPersona = 27;

            Console.WriteLine(edadPersona);

            // Conversiones

            // Conversión explícita o casting

            double temperatura = 34.9;

            int temperaturaMadrid;

            temperaturaMadrid = (int) temperatura;

            Console.WriteLine(temperaturaMadrid);

            // Conversión implícita

            int habitantesCiudad = 10000000;

            long habitantesCiudad2018 = habitantesCiudad;

            Console.WriteLine(habitantesCiudad2018);

            float pesoMaterial = 5.78F;

            double pesoMaterialPre = pesoMaterial;

            Console.WriteLine(pesoMaterialPre);

            // Conversiones de tipo (texto a número)

            Console.WriteLine("Introduce el primer número");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + (num1 + num2));
        }
    }
}
