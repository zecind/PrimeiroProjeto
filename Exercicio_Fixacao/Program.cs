using System;
using System.Globalization;

namespace Exercicio_Fixacao {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Usando Placeholders\n");
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}\n{2}, cujo preço é $ {3:F2}", produto1, preco1, produto2, preco2);
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("Usando Interpolação\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código: {codigo} e gênero {genero}.");
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("Usando Concatenação\n");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais):" + medida.ToString("F3"));
            Console.WriteLine("Separador decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
