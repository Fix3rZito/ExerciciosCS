using System;

namespace ExEstruturaSequencial1
//Ex1: Faça um programa para ler dois valores inteiros, e depois mostrar
//na tela a soma desses números com uma mensagem explicativa, conforme exemplos:
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("digite um valor inteiro: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite outro valor inteiro: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.Clear();

            int SomaTotal = valor1 + valor2;

            Console.Write($"Soma: {SomaTotal}");
        }
    }
}