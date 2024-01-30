using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE
{
    public class MaxMex
    {
        public static void CalcularMex(int[] array)
        {
            //No sea negativo
            //numero reducido <= indice
            //No se repita en el nuevo array
            //Extraer el mayor posible
            
            int[] arrayResult = new int[array.Length];
            for(int index = 0; index < array.Length; index++)
            {
                int numero = array[index];
                while(numero >= index)
                {
                    if(numero > 0) {
                        numero--;
                    }
                    
                    if(numero == index)
                    {
                        arrayResult[index] = numero;
                        break;
                    }
                }
            }
            int maxMex=0;
            Array.Sort(arrayResult);
            for (int index = 0;index < arrayResult.Length; index++)
            {
                int[] numerosAEvaluar = Enumerable.Range(0, arrayResult.Length+1).ToArray();
                int numero = arrayResult[index];
                for(int i = 0; i < numerosAEvaluar.Length; i++)
                {
                    if (numerosAEvaluar[i] != numero)
                    {
                        maxMex = numerosAEvaluar[i];
                    }
                }
            }
            Console.WriteLine("MaxMex: "+maxMex);
        }
    }
}
