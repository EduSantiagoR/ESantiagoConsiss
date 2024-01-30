using System.Security.Cryptography.X509Certificates;

namespace CONSOLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////Matriz 1
            //int[,] matriz1 = new int[3, 3];
            //matriz1[0,0] = 1;
            //matriz1[0, 1] = 2;
            //matriz1[0, 2] = 3;
            //matriz1[1, 0] = 4;
            //matriz1[1, 1] = 5;
            //matriz1[1, 2] = 6;
            //matriz1[2, 0] = 7;
            //matriz1[2, 1] = 8;
            //matriz1[2, 2] = 9;
            ////Matriz2
            //int[,] matriz2 = new int[3, 3];
            //matriz2[0, 0] = 1;
            //matriz2[0, 1] = 1;
            //matriz2[0, 2] = 1;
            //matriz2[1, 0] = 5;
            //matriz2[1, 1] = 6;
            //matriz2[1, 2] = 1;
            //matriz2[2, 0] = 7;
            //matriz2[2, 1] = 8;
            //matriz2[2, 2] = 1;
            ////Matriz resultante
            //int[,] matrizResult = new int[3, 3];
            ////Suma de la matriz
            //for (int fila = 0; fila < 3; fila++)
            //{
            //    for(int columna = 0; columna < 3; columna++)
            //    {
            //        matrizResult[fila, columna] = matriz1[fila, columna] + matriz2[fila, columna];
            //    }
            //}
            ////Imprimir resultado
            //for (int fila = 0; fila < 3; fila++)
            //{
            //    for (int columna = 0; columna < 3; columna++)
            //    {
            //        Console.Write(matrizResult[fila, columna] + " ");
            //        if(columna == 2)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}
            ////Factorial
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("El factorial es: "+ Factorial(numero));

            //int[] array = { 1, 2, 2 };
            //MaxMex.CalcularMex(array);

            //Hilo
            //ThreadStart start = new ThreadStart(Algo);
            //Thread hilo = new Thread(start);
            //hilo.Start();
            //Thread.Sleep(5000);


            EjerciciosLogica.Ejercicio2();
            //EjerciciosLogica.Ejercicio4();
            //EjerciciosLogica.Ejercicio6();
            //EjerciciosLogica.Ejercicio3("Arde ya la yedra");
            //EjerciciosLogica.Ejercicio5(4);
            Console.ReadKey();
        }
        public static int Factorial(int numero)
        {
            if (numero == 1 || numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * Factorial(numero - 1);
            }
        }

        public static void Algo()
        {
            Console.WriteLine("Hilo inicio");
        }
    }
}
