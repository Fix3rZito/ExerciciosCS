using System;
using System.Globalization;

namespace ExEstruturaSequencial1
//Faça um programa para ler o valor do raio de um círculo, e depois mostrar
//o valor da área deste círculo com quatro casas decimais conforme exemplos.
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio de um círculo: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            double pi = 3.14159;
            double circle_area = pi * (Math.Pow(radius, 2));

            Console.WriteLine("Área do círculo = {0}",  circle_area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}