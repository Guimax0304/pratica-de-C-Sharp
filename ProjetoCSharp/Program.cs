using System;
using System.Globalization;
using System.Security.AccessControl;

namespace ProjetoCSharp {
    internal class Program {

        static void Main(string[] args) {


            // Exercicio: encadeamento
            Console.WriteLine("Digite a hora atual em numero inteiro: ");

            int hour = int.Parse(Console.ReadLine());


                if (hour < 12) {
                    Console.WriteLine("Bom dia!");
                }
                else if (hour < 18) {
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa noite!");
                }
        }
    }
}