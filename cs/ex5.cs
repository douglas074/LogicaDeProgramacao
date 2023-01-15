using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 5:
            // Leia um vetor de 10 posições e em seguida um valor X qualquer. Seu programa devera fazer uma busca do valor de X no vetor lido e informar a posição em que foi encontrado ou se não foi encontrado.
            int[] Positions = new int[10];
            int[] Result = new int[2];
            int Aux;
            Console.WriteLine("Entre com 10 valores.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions[i] = Int16.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe o valor que sera procurado:");
            Aux = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (Aux == Positions[i])
                {
                    Result[1] = i;
                    Result[0] = 1;
                }
            }

            if (Result[0] == 1)
            {
                Console.WriteLine($"O valor {Aux} foi encontrado na posicao {Result[1]}");
                Environment.Exit(0);
            }
            Console.WriteLine($"O valor {Aux} não foi encontrado!");

            //Fim ex 5
        }
    }
}
