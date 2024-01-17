using System;

namespace EstruturaRepetitivaFor6 
    //Ler um número inteiro N e calcular todos os seus divisores.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um número N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }

            }
        }
    }
}