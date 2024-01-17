using System;
using System.Globalization;

namespace exercicio6aula3
{
    //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
    //Em seguida, calcule e mostre:
    //a) a área do triângulo retângulo que tem A por base e C por altura.
    //b) a área do círculo de raio C. (pi = 3.14159)
    //c) a área do trapézio que tem A e B por bases e C por altura.
    //d) a área do quadrado que tem lado B.
    //e) a área do retângulo que tem lados A e B.

    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva os valor respectivos para A, B e C:");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double triangleArea = (a * c)/2;
            double circleArea = 3.14159 * (Math.Pow(c, 2));
            double trapezeArea = ((a + b) * c / 2);
            double squareArea = (b * b);
            double retangleArea = a * b;

            Console.WriteLine($"Triângulo: {triangleArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Círculo: {circleArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio : {trapezeArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {squareArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {retangleArea.ToString("F3", CultureInfo.InvariantCulture)} ");

        }
    }
}