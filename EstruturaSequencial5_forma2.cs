using System;
using System.Globalization;

namespace ExEstruturaSequencial5_2
///Fazer um programa para ler o código de uma peça 1, o número de peças 1,
///o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2
///e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
{
    internal class Program {
    static void Main(string[] args) {
            Console.WriteLine("Digite o valor do primeiro item, a sua quantidade e o seu valor unitário: ");
            string[] vet = Console.ReadLine().Split(' ');
            int item1 = int.Parse(vet[0]);
            int item1Quant = int.Parse(vet[1]);
            double item1Value = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine("Digite o valor do segundo item, a sua quantidade e o seu valor unitário: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            int item2 = int.Parse(vet2[0]);
            int item2Quant = int.Parse(vet2[1]);
            double item2Value = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            Console.Clear();

            double total = (item1Value * item1Quant) + (item2Value * item2Quant);

            Console.WriteLine("valor à pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}