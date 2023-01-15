using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 8:
            // Leia dois vetores de 10 posições e calcule um terceiro vetor contendo, nas posições pares os valores do primeiro e nas posições impares os valores do segundo.

            int[] Positions1 = new int[10];
            int[] Positions2 = new int[10];
            int[] Positions3 = new int[20];
            int j = 0, k = 0;

            Console.WriteLine("Entre com 10 valores do primeiro vetor.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions1[i] = Int16.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entre com 10 valores do segundo vetor.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions2[i] = Int16.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Positions3[i] = Positions1[j];
                    j++;
                }
                else
                {
                    Positions3[i] = Positions2[k];
                    k++;
                }
            }

            Console.WriteLine("O valores do terceiro vetor ficaram:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i} valor: {Positions3[i]}");
            }

            //Fim ex 8
        }
    }
}
