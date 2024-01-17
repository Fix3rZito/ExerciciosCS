using System;

namespace EstruturaCondicional3 {
    //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem
    //"Sao Multiplos" ou "Nao são Multiplos",
    //indicando se os valores lidos são múltiplos entre si. Atenção:
    //os números devem poder ser digitados em ordem crescente ou decrescente.
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois número e diremos se os mesmos são múltiplos: ");
            string[] vet = Console.ReadLine().Split(" ");
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0) 
                Console.WriteLine("São Múltiplos");
            else
                Console.WriteLine("Não são múltiplos");


        }
    }
}
