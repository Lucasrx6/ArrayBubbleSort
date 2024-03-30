using System;
using System.Security.Policy;

namespace ArrayBubbleSort
{
    internal class Program
    {
        static Random aleatorio;
        static int[] numeros;
        static void Main(string[] args)
        {
            
            numeros = new int[15];
            aleatorio = new Random();

            Preencher();

            
            Console.WriteLine("_____________________Imprimindo sem ordenação_____________________");
            Imprimir();




            Console.WriteLine("_____________________Imprimindo em ordem crescente_____________________");
            OrdernarCrescente();
            Imprimir();




            Console.WriteLine("_____________________Imprimindo em orden decrescente_____________________");
            OrdernarDecrescente();
            Imprimir();

        }

        public static void Preencher()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 100);

            }
            Console.WriteLine(" ");
        }




        private static void OrdernarCrescente()
        {
            for(int i = 0; i < numeros.Length-1; i++)
            {
                for(int j=i+1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

        }

        private static void OrdernarDecrescente()
        {

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

        }


        private static void Imprimir()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("O numero na posição " + (i + 1) + " recebeu o numero aleatório " + numeros[i]);
            }
        }





    }
}
