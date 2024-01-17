using System;

namespace EstruturaRepetitivaFor1 
    // Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os
    //ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
{
    internal class Program {
        static void Main(string[] args) {
            
            Console.Write("Escreva um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            for (int cont = 1; cont <= x; cont++) {
                if(cont % 2 != 0)
                     Console.WriteLine(cont);
            }
        }
    }
}