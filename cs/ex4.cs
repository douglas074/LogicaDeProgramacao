using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 4:
            // Leia um vetor de 10 posições e troque os 5 primeiros valores pelos 5 últimos e vice-e-versa. Escreva ao final o vetor obtido.
            int[] Positions = new int[10];
            int Aux;
            int j;
            Console.WriteLine("Entre com 10 valores.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions[i] = Int16.Parse(Console.ReadLine());
            }

            j = 9;

            for (int i = 0; i < 5; i++)
            {
                Aux = Positions[i];
                Positions[i] = Positions[j];
                Positions[j] = Aux;
                j = j - 1;
            }

            Console.WriteLine("Os valores reorganizados ficaram:");

            foreach (var item in Positions)
            {
                Console.WriteLine($"{item}");
            }
            //Fim ex 4
        }
    }
}
