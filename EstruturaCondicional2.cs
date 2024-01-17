using System;

namespace EstruturaCondicional2 {
    //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite e será indicado se o mesmo é par ou ímpar: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Ímpar");
        }
    }
}
