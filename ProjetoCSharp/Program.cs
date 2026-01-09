using System;
using System.Globalization;
using System.Security.AccessControl;

namespace ProjetoCSharp {
    internal class Program {

        static void Main(string[] args) {


            // Exercicio: encadeamento
            Console.WriteLine("Digite dois numero inteiro separados por um espaço: ");

            String[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);



            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }


        }
    }
}