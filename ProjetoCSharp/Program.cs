using System;
using System.Globalization;

namespace ProjetoCSharp {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Entre com o seu nome completo");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int q_quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            float altura = float.Parse(dados[2], CultureInfo.InvariantCulture);

        }
    }
}