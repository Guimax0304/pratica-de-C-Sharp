using System;
using System.Globalization;
using System.Security.AccessControl;

namespace ProjetoCSharp {
    internal class Program {
        static void Main(string[] args) {
            // Exercicio: condicional
            Console.WriteLine("Digite a hora inicial e final (ex:12-21): ");

            String[] valores = Console.ReadLine().Split('-');

            int hinicial = int.Parse(valores[0]);
            int hfinal = int.Parse(valores[1]);
            int duracao = 0;
            if (hinicial > hfinal) {
                duracao = (24 - hinicial) + hfinal;

                Console.WriteLine("A duração final é de : " + duracao + " horas.");
            }
            else {
                duracao= hfinal - hinicial;
                Console.WriteLine("A duração final é de : " + duracao + " horas.");
            }
        }
    }
}