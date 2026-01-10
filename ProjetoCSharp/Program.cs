using System;
using System.Globalization;
using System.Security.AccessControl;

namespace ProjetoCSharp {
    internal class Program {
        static void Main(string[] args) {
            // Exercicio: condicional
            Console.WriteLine("Digite o código e quant do produto que vc deseja (ex: 1,4) : ");

            String[] valores = Console.ReadLine().Split(',');

            int preco = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);

            double total;
            if (preco == 1) {
                total = quant * 4.0;
            }
            else if (preco == 2) {
                total = quant * 4.5;
            }
            else if (preco == 3) {
                total = quant * 5.0;
            }
            else if (preco == 4) {
                total = quant * 2.0;
            }
            else {
                total = quant * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}