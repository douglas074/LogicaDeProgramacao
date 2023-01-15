using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 9:
            // Leia um vetor de 10 posições e verifique se existem valores iguais e os escreva.

            int Positions = new int[10];
            int Count = 0;

            Console.WriteLine("Informe 10 valores:");
            for (int i = 0; i < 10; i++)
            {
                Positions[i] = Int16.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os valores repitidos foram:");

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Positions[i] == Positions[j])
                    {
                        Count++;
                    }
                }
                Console.WriteLine($"O valor {Positions[j]} apareceu {Count} vezes");
                Count = 0;
            }

            //Fim ex 9
        }
    }
}
