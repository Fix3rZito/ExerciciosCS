using System;

namespace EstruturaCondicional1
//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Insira um número e será indicado se o mesmo é negativo ou positivo: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 0) {
                Console.WriteLine("POSITIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
