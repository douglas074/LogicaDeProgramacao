using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 3:
            // Declare um vetor de 10 posições e o preencha com os 10 primeiros números impares e o escreva.
            short[] Positions = new short[10];
            short Aux;
            Console.WriteLine("Entre com 10 valores.");

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine($"Informe o {i}º valor");
                    Aux = short.Parse(Console.ReadLine());
                } while (Aux % 2 == 0);
                Positions[i] = Aux;
            }

            Console.WriteLine("Os valores impares foram:");

            foreach (var item in Positions)
            {
                Console.WriteLine($"{item}");
            }
            //Fim ex 3
        }
    }
}
