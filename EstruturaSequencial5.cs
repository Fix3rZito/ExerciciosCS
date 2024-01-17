using System;
using System.Globalization;

namespace ExEstruturaSequencial5
///Fazer um programa para ler o código de uma peça 1, o número de peças 1,
///o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2
///e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
{
    internal class Program {
    static void Main(string[] args) {
            Console.Write("Código do primeiro item: ");
            int item1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Quantidade do item de código {item1}: ");
            int item1Quant = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Valor unitário do item de código {item1}: ");
            double item1Value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            Console.Write("Código do segundo item: ");
            int item2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Quantidade do item de código {item2}: ");
            int item2Quant = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Valor unitário do item de código {item2}: ");
            double item2Value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            double total = (item1Value * item1Quant) + (item2Value * item2Quant);

            Console.WriteLine("valor à pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}