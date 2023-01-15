using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 7:
            // Leia um vetor de 10 posições e atribua valor 0 para todos os elementos que possuírem valores negativos.

            int[] Positions = new int[10];

            Console.WriteLine("Entre com 10 valores.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions[i] = Int16.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (Positions[i] < 0)
                {
                    Positions[i] = 0;
                }
            }

            Console.WriteLine("O valores ficaram:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} valor: {Positions[i]}");
            }

            //Fim ex 7
        }
    }
}
