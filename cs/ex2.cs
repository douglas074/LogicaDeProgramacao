using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 2:
            // Leia um vetor de 12 posições e em seguida ler também dois valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu programa deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.

            short[] Positions = new short[12];
            sbyte[] Aux = new sbyte[2];
            Console.WriteLine("Entre com 12 valores");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Informe o {i}º valor");
                Positions[i] = short.Parse(Console.ReadLine());
            }

            Console.WriteLine("informe duas posições que serão somadas:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe o {i}");
                Aux[i] = sbyte.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma dos valores {Positions[Aux[0]]} + {Positions[Aux[1]]} é igual à {Positions[Aux[0]] + Positions[Aux[1]]}");

            //Fim ex 2
        }
    }
}
