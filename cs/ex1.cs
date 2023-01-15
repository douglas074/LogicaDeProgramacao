using System;
using System.Globalization;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicios de estrutura sequencial 
            // ex 1:

            string[] Aux;
            string Name;
            byte Rooms;
            float Price;

            Console.WriteLine("Entre com seu nome completo:");
            Name = Console.ReadLine();

            Console.WriteLine("Quantos quartos há em sua casa?");
            Rooms = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            Price = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            Aux = Console.ReadLine().Split(' ');

            Console.WriteLine($"\n\nNome completo: {Name}");
            Console.WriteLine($"Quantidade de quartos: {Rooms}");
            Console.WriteLine($"Sobrenome: {Aux[0]}");
            Console.WriteLine($"Idade: {Aux[1]}");
            Console.WriteLine($"Altura: {Aux[2]}", CultureInfo.InvariantCulture);

            //Fim ex 1
        }
    }
}
