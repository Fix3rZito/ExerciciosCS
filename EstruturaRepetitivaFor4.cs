using System;
using System.Globalization;

namespace EstruturaRepetitivaFor4
    //Fazer um programa para ler um número N.
    //Depois leia N pares de números e mostre a divisão do primeiro pelo
    //segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
{
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Deseja realizar o teste com quantos valores? ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            
            for (int i = 0; i < n; i++) {

                Console.Write("Digite o valor X e o valor Y: ");
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y == 0) {
                    Console.vet("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
