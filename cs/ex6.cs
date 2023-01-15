using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 6:
            // Leia um vetor de 10 posições. Contar e escrever quantos valores pares ele possui.

            int[] Positions = new int[10];
            int[] Result = new int[2];
            int? Aux = 0;
            Console.WriteLine("Entre com 10 valores.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions[i] = Int16.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (Positions[i] % 2 == 0)
                {
                    Aux++;
                }
            }
            if (Aux != null)
            {
                Console.WriteLine($"Existem {Aux} numero/s par/pares dentro do vetor");
            }
            else
            {
                Console.WriteLine("Nao ha nenhuma valor par dentro do vetor.");
            }

            //Fim ex 6
        }
    }
}
