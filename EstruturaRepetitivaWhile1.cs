using System;

namespace EstruturaRepetitivaWhile1
    //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
    //incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
    //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002..
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.Write("Senha incorreta, digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso liberado!");
        }
    }
}