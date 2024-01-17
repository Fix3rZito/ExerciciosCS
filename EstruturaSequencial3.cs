using System;

namespace ExEstruturaSequencial3
//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir,
//calcule e mostre a diferença do produto de A e B pelo produto de C e D
//segundo a fórmula: DIFERENCA = (A* B - C* D)
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor inteiro A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite um valor inteiro B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite um valor inteiro C: ");
            int C = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite um valor inteiro D: ");
            int D = int.Parse(Console.ReadLine());
            Console.Clear();

            int resultado = (A * B) - (C * D);

            Console.WriteLine("Resultado: " + resultado);

        }
    }
}