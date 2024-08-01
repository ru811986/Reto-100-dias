using System;

namespace ejemplo006
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            double num1 = PedirNumero(1);
            double num2 = PedirNumero(2);
            int op = PedirOperacion();
            switch(op)
            {
                case 1:
                    Console.WriteLine($"Suma: {Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Resta: {Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplicación: {Multiplicar(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"División: {Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("La operación no existe");
                    break;
            }
        }

        private static double PedirNumero(int indice)
        {
            Console.WriteLine($"Introduzca el número {indice}");
            return double.Parse(Console.ReadLine());
        }

        private static int PedirOperacion()
        {
            Console.WriteLine("Selecciona la operación (1 - suma, 2 - resta, 3 - multiplicación, 4 - división)");
            return int.Parse(Console.ReadLine());
        }

        private static double Sumar(double x, double y)
        {
            return x + y;
        }

        private static double Restar(double x, double y)
        {
            return x - y;
        }

        private static double Multiplicar(double x, double y)
        {
            return x * y;
        }

        private static double Dividir(double x, double y)
        {
            return x / y;
        }
    }
}
