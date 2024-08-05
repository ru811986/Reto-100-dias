using System;

namespace ejemplo012
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            Matriz matrizA = OperacionesMatriciales.Inicializar(2, 2);
            OperacionesMatriciales.Mostrar(matrizA);
            Console.WriteLine("- - - - - -");
            Matriz suma = OperacionesMatriciales.Sumar(matrizA, matrizA);
            OperacionesMatriciales.Mostrar(suma);
            Console.WriteLine("- - - - - -");
            Matriz resta = OperacionesMatriciales.Restar(matrizA, matrizA);
            OperacionesMatriciales.Mostrar(resta);
            Console.WriteLine("- - - - - -");
            Matriz multiplicacionPorNumero = OperacionesMatriciales.Multiplicar(3, matrizA);
            OperacionesMatriciales.Mostrar(multiplicacionPorNumero);
            Console.WriteLine("- - - - - -");
            Matriz multiplicacion = OperacionesMatriciales.Multiplicar(matrizA, matrizA);
            OperacionesMatriciales.Mostrar(multiplicacion);
            Console.WriteLine("- - - - - -");
            Matriz transposicion = OperacionesMatriciales.Transponer(matrizA);
            OperacionesMatriciales.Mostrar(transposicion);
            Console.WriteLine("- - - - - -");
        }
    }

    class Matriz
    {
        private int numFilas;
        private int numColumnas;
        private double[][] valores;

        public Matriz(int numFilas, int numColumnas)
        {
            this.numFilas = numFilas;
            this.numColumnas = numColumnas;
            this.valores = new double[numFilas][];
            for (int i = 0; i < numFilas; i++)
            {
                this.valores[i] = new double[numColumnas];
            }
        }

        public int GetNumFilas()
        {
            return numFilas;
        }

        public int GetNumColumnas()
        {
            return numColumnas;
        }

        public double GetValor(int numFila, int numColumna)
        {
            return valores[numFila][numColumna];
        }

        public void SetValor(int numFila, int numColumna, double valor)
        {
            this.valores[numFila][numColumna] = valor;
        }
    }

    class OperacionesMatriciales
    {
        private OperacionesMatriciales() { }

        public static Matriz Inicializar(int numFilas, int numColumnas)
        {
            Matriz matriz = new Matriz(numFilas, numColumnas);
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numColumnas; j++)
                {
                    Console.WriteLine($"Introduzca el elemento [{i + 1}, {j + 1}]");
                    matriz.SetValor(i, j, double.Parse(Console.ReadLine()));
                }
            }
            return matriz;
        }

        public static void Mostrar(Matriz matriz)
        {
            for (int i = 0; i < matriz.GetNumFilas(); i++)
            {
                for (int j = 0; j < matriz.GetNumColumnas(); j++)
                {
                    Console.Write(" " + matriz.GetValor(i, j));
                }
                Console.WriteLine();
            }
        }

        public static Matriz Sumar(Matriz m1, Matriz m2)
        {
            if (m1 == null || m2 == null)
            {
                Console.WriteLine("Alguna matriz no se ha inicializado");
                return null;
            }
            else if (m1.GetNumFilas() != m2.GetNumFilas() || m1.GetNumColumnas() != m2.GetNumColumnas())
            {
                Console.WriteLine("No tienen las mismas dimensiones");
                return null;
            }
            else
            {
                Matriz suma = new Matriz(m1.GetNumFilas(), m1.GetNumColumnas());
                for (int i = 0; i < suma.GetNumFilas(); i++)
                {
                    for (int j = 0; j < suma.GetNumColumnas(); j++)
                    {
                        suma.SetValor(i, j, m1.GetValor(i, j) + m2.GetValor(i, j));
                    }
                }
                return suma;
            }
        }

        public static Matriz Restar(Matriz m1, Matriz m2)
        {
            if (m1 == null || m2 == null)
            {
                Console.WriteLine("Alguna matriz no se ha inicializado");
                return null;
            }
            else if (m1.GetNumFilas() != m2.GetNumFilas() || m1.GetNumColumnas() != m2.GetNumColumnas())
            {
                Console.WriteLine("No tienen las mismas dimensiones");
                return null;
            }
            else
            {
                Matriz resta = new Matriz(m1.GetNumFilas(), m1.GetNumColumnas());
                for (int i = 0; i < resta.GetNumFilas(); i++)
                {
                    for (int j = 0; j < resta.GetNumColumnas(); j++)
                    {
                        resta.SetValor(i, j, m1.GetValor(i, j) - m2.GetValor(i, j));
                    }
                }
                return resta;
            }
        }

        public static Matriz Multiplicar(double num, Matriz m)
        {
            if (m == null)
            {
                Console.WriteLine("Alguna matriz no se ha inicializado");
                return null;
            }
            else
            {
                Matriz multiplicaPorNum = new Matriz(m.GetNumFilas(), m.GetNumColumnas());
                for (int i = 0; i < multiplicaPorNum.GetNumFilas(); i++)
                {
                    for (int j = 0; j < multiplicaPorNum.GetNumColumnas(); j++)
                    {
                        multiplicaPorNum.SetValor(i, j, num * m.GetValor(i, j));
                    }
                }
                return multiplicaPorNum;
            }
        }

        public static Matriz Multiplicar(Matriz m1, Matriz m2)
        {
            Matriz multiplicacion = null;
            if (m1 == null || m2  == null)
            {
                Console.WriteLine("Alguna matriz no se ha inicializado");
                return multiplicacion;
            } else if (m1.GetNumColumnas() != m2.GetNumFilas())
            {
                Console.WriteLine("La segunda no tiene el mismo número de filas que la primera de columnas");
                return multiplicacion;
            } else
            {
                multiplicacion = new Matriz(m1.GetNumFilas(), m2.GetNumColumnas());
                for (int i = 0; i < m1.GetNumFilas(); i++)
                {
                    for (int j = 0; j < m2.GetNumColumnas(); j++)
                    {
                        double suma = 0.0;
                        for (int k = 0; k < m1.GetNumColumnas(); k++)
                        {
                            suma += m1.GetValor(i, k) * m2.GetValor(k, j);
                        }
                        multiplicacion.SetValor(i, j, suma);
                    }
                }
                return multiplicacion;
            }
        }

        public static Matriz Transponer(Matriz m)
        {
            if (m == null)
            {
                Console.WriteLine("La matriz no se ha inicializado");
                return null;
            } else
            {
                Matriz transpuesta = new Matriz(m.GetNumColumnas(), m.GetNumFilas());
                for (int i = 0; i < m.GetNumFilas(); i++)
                {
                    for (int j = 0; j < m.GetNumColumnas(); j++)
                    {
                        transpuesta.SetValor(i, j, m.GetValor(j, i));
                    }
                }
                return transpuesta;
            }
        }
    }
}
