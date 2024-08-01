using System;

namespace ejemplo007
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            string continuar;
            do
            {
                int numOperandos = PedirNumOperandos();
                string mensajeOp = PedirMensaje(numOperandos);
                int op;
                switch (numOperandos)
                {
                    case 1:
                        double num = PedirNumero(1);
                        op = PedirOperacion(mensajeOp);
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine($"Número al cuadrado: {Potencia2(num)}");
                                break;
                            case 2:
                                Console.WriteLine($"Número al cubo: {Potencia3(num)}");
                                break;
                            case 3:
                                Console.WriteLine($"Raíz cuadrada: {Raiz2(num)}");
                                break;
                            case 4:
                                Console.WriteLine($"Raíz cúbica: {Raiz3(num)}");
                                break;
                            default:
                                Console.WriteLine("La operación no existe");
                                break;
                        }
                        break;
                    case 2:
                        double num1 = PedirNumero(1);
                        double num2 = PedirNumero(2);
                        op = PedirOperacion(mensajeOp);
                        switch (op)
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
                        break;
                    default:
                        Console.WriteLine(mensajeOp);
                        break;
                }
                continuar = PedirContinuar();
            } while ("S".Equals(continuar));
        }

        private static int PedirNumOperandos()
        {
            Console.WriteLine("Introduzca el número de operandos");
            return int.Parse(Console.ReadLine());
        }

        private static string PedirMensaje(int numOperandos)
        {
            string mensaje = "";
            switch(numOperandos)
            {
                case 1:
                    mensaje = "Selecciona la operación (1 - número al cuadrado, 2 - número al cubo, 3 - raíz cuadrada, 4 - raíz cúbica)";
                    break;
                case 2:
                    mensaje = "Selecciona la operación (1 - suma, 2 - resta, 3 - multiplicación, 4 - división)";
                    break;
                default:
                    mensaje = "No hay operaciones con más de dos operandos";
                    break;
            }
            return mensaje;
        }

        private static string PedirContinuar()
        {
            Console.WriteLine("¿Desea continuar? (S/N)");
            return Console.ReadLine();
        }

        private static double PedirNumero(int indice)
        {
            Console.WriteLine($"Introduzca el número {indice}");
            return double.Parse(Console.ReadLine());
        }

        private static int PedirOperacion(string mensajeOp)
        {
            Console.WriteLine(mensajeOp);
            return int.Parse(Console.ReadLine());
        }

        private static double Potencia2(double x)
        {
            return Math.Pow(x, 2);
        }

        private static double Potencia3(double x)
        {
            return Math.Pow(x, 3);
        }

        private static double Raiz2(double x)
        {
            return Math.Pow(x, 1.0/2.0);
        }

        private static double Raiz3(double x)
        {
            return Math.Pow(x, 1.0/3.0);
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
