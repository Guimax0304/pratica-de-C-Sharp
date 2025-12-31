using System;
using System.Globalization;

namespace ProjetoCSharp {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Entre com numero inteiro:");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0) 
               {
               Console.WriteLine("O número é par");
               }
            else 
               {
               Console.WriteLine("O número é ímpar");
               };
        }
    }
}