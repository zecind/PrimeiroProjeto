using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("PLACEHOLDER\n");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n--------------------------------------------------------------\n");
            Console.WriteLine("INTERPOLAÇÃO\n");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");
            Console.WriteLine("\n--------------------------------------------------------------\n");
            Console.WriteLine("CONCATENAÇÃO - MÉTODO TRADICIONAL\n");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            Console.WriteLine("\n--------------------------------------------------------------\n");
        }
    }
}
