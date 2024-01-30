using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
        public static void Ejercicio2()
        {
            Console.WriteLine("Ingresa un número.");
            int numero = int.Parse(Console.ReadLine());
            Dictionary<int, int> cantidadLetras = new Dictionary<int, int>
            {
                { 0, 4 }, { 1, 3 }, { 2, 3 } , { 3, 4 }, { 4, 6 }, { 5, 5 }, { 6, 4 }, { 7, 5 }, { 8, 4 }, { 9, 5 }
            };
            if(numero <= 9)
            {
                Console.WriteLine($"Cantidad de letras: {cantidadLetras[numero]}.");
            }
            else
            {
                int decenas = numero / 10;
                int unidades = numero % 10;
                int cantidadTotalLetras = cantidadLetras[decenas] + cantidadLetras[unidades];
                Console.WriteLine($"El numero se separo en {decenas} y {unidades}. Por lo tanto su cantidad total de letras es {cantidadTotalLetras}.");
            }
        }
        //Detectar palindromo
        public static void Ejercicio3(string palabra)
        {
            palabra = palabra.ToLower().Replace(" ", "");
            char[] letras = palabra.ToCharArray();
            bool esPalindromo = true;
            int lastIndex = letras.Length - 1;
            for (int i = 0; i < letras.Length / 2; i++)
            {
                if (letras[i] != letras[lastIndex])
                {
                    esPalindromo = false;
                    break;
                }
                lastIndex--;
            }
            Console.WriteLine(esPalindromo ? "Es palindromo." : "No es palindromo.");
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
        //Registrar productos
        public static void Ejercicio5(int numeroProductos)
        {
            Dictionary<string, int> productos = new Dictionary<string, int>();
            for (int i = 1; i <= numeroProductos; i++)
            {
                Console.WriteLine($"Escribe el nombre del producto numero {i}: ");
                string nombreProducto = Console.ReadLine();
                Console.WriteLine($"Escribe el precio del producto numero {i}: ");
                int precioProducto = int.Parse(Console.ReadLine());
                productos.Add(nombreProducto, precioProducto);
            }
            List<string> keys =  new List<string>(productos.Keys);
            string keyPrecioMasAlto = keys[0];
            string keyPrecioMasBajo = keys[0];
            for (int i = 0; i < numeroProductos; i++)
            {
                if(productos[keys[i]] > productos[keyPrecioMasAlto])
                {
                    keyPrecioMasAlto = keys[i];
                }
                if (productos[keys[i]] < productos[keyPrecioMasBajo])
                {
                    keyPrecioMasBajo = keys[i];
                }
            }
            Console.WriteLine($"El producto con el precio mas alto es {keyPrecioMasAlto} con costo de $ {productos.GetValueOrDefault(keyPrecioMasAlto)}");
            Console.WriteLine($"El producto con el precio mas bajo es {keyPrecioMasBajo} con costo de $ {productos.GetValueOrDefault(keyPrecioMasBajo)}");
        }
        //Herencia de clases e interfaces.
        public static void Ejercicio6()
        {
            ClaseA claseA = new ClaseA();
            Console.WriteLine(((ClaseB)claseA).MetodoA());
            Console.WriteLine(claseA.MetodoB());
            Console.WriteLine(claseA.MetodoA());
        }
    }
}
