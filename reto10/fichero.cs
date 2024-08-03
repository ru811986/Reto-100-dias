using System;

namespace ejemplo010
{
    class Fichero001
    {
        static void Main(string[] args)
        {
            Matriz matrizA = OperacionesMatriciales.Inicializar(3, 3);
            OperacionesMatriciales.Mostrar(matrizA);
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
    }
}
