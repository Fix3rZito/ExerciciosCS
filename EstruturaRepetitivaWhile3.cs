using System;

namespace EstruturaRepetitivaWhile3
    //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
    //Escreva um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma:
    //1.Álcool 2.Gasolina 3.Diesel 4.Fim).
    //Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código
    //(até que seja válido). O programa será encerrado quando o código informado for o número 4.
    //Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escolha sua Preferência abaixo:\n1 - Àlcool\n2 - Gasolina\n3 - Diesel\n4 - Fim");
            int pref = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int fim = 0;

        while (pref != 4) { 


                    if (pref == 1)
                       alcool++;
                    else if (pref == 2)
                       gasolina++;
                    else
                       diesel++;
                pref = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine($"Álcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {diesel}");

        }
    }
}