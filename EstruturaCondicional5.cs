using System;
using System.Globalization;

namespace EstruturaCondicional5 {
    //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
    //A seguir, calcule e mostre o valor da conta a pagar.
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva o código e a quantidade do item com base na tabela abaixo:");
            Console.WriteLine("Código   Especificação   Preço");
            Console.WriteLine("1       Cachorro-quente  R$4.00");
            Console.WriteLine("2       X-Salada         R$4.50");
            Console.WriteLine("3       X-Bacon          R$5.00");
            Console.WriteLine("4       Torrada Simples  R$2.00");
            Console.WriteLine("5       Refrigerante     R$1.50");
            string[] vet = Console.ReadLine().Split(" ");
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double preco = 0;
            double precoTotal = 0;
            bool continua = true;

            if (codigo == 1) {
                preco = 4.00;
            }
            else if (codigo == 2) {
                preco = 4.50;
            }
            else if (codigo == 3) {
                preco = 5.00;
            }
            else if (codigo == 4) {
                preco = 2.00;
            }
            else if (codigo == 5) {
                preco = 1.50;
            }
            else {
                continua = false;
            }

            if (continua != false) {
                precoTotal = quantidade * preco;
                Console.WriteLine($"Total: R${precoTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                Console.WriteLine("Código Inválido!");
            }

        }
    }
}
