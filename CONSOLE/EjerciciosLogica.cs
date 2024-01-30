using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE
{
    public class EjerciciosLogica
    {
        //Letras comunes en dos listas
        public static void Ejercicio1()
        {
            List<string> Lista1 = new List<string> { "A", "B", "C", "D", "E", "F" };
            List<string> Lista2 = new List<string> { "B", "E", "G", "H", "I", "J" };
            List<string> comunes = new List<string>();

            for (int i = 0; i < Lista1.Count; i++)
            {
                for (int j = 0; j < Lista1.Count; j++)
                {
                    if (Lista1[i] == Lista2[j])
                    {
                        comunes.Add(Lista1[i]);
                        break;
                    }
                }
            }
            Console.Write("Los valores comunes son: ");
            foreach (string letra in comunes)
            {
                Console.Write(letra+ ", ");
            }
        }
        //Conteo de letras
        public static void Ejercicio2(int numero)
        {
            Console.WriteLine("La cantidad de letras son: ");
            if (numero <= 5)
            {
                Console.Write(numero == 5 ? "5" : "");
                Console.Write(numero == 4 ? "6" : "");
                Console.Write(numero == 3 ? "4" : "");
                Console.Write(numero == 2 ? "3" : "");
                Console.Write(numero == 1 ? "3" : "");
            }
            else
            {
            }
        }
        //Recorrer numeros del 1 al 100
        public static void Ejercicio4()
        {
            List<int> numerosPares = new List<int>();
            List<int> numerosDivisibles3 = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                bool serguir = false;
                if(i % 2 == 0)
                {
                    numerosPares.Add(i);
                    if(i % 3 == 0)
                    {
                        numerosDivisibles3.Add(i);
                    }
                }
                else
                {
                    serguir = true;
                }
                if(serguir)
                {
                    if (i % 3 == 0)
                    {
                        numerosDivisibles3.Add(i);
                    }
                }
            }
            Console.Write("Numeros pares: ");
            for (int i = 0;i < numerosPares.Count; i++)
            {
                Console.Write(numerosPares[i]+ " ");
            }
            Console.WriteLine("\n");
            Console.Write("Numeros divisibles entre 3: ");
            for (int i = 0; i < numerosDivisibles3.Count; i++)
            {
                Console.Write(numerosDivisibles3[i] + " ");
            }
        }

    }
}
