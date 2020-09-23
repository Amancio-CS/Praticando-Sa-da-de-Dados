using System;
using System.Globalization;

namespace ATV_SaídaDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string Produto1 = "computador";
            string Produto2 = "mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            Double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{Produto1} cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{Produto2} cujo preço é $ {preco2:F2}");
            Console.WriteLine(                                            );
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genêro: " + genero);
            Console.WriteLine(                                            );
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }

    }
}
