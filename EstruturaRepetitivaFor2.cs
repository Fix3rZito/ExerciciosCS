using System;

namespace EstruturaRepetitivaFor2 
//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X
//que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20]
//e quantos estão fora do intervalo, mostrando
//essas informações conforme exemplo
//(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite quantos valores deseja escrever: ");
            int n = int.Parse(Console.ReadLine());
            int cont = 1;
            int in1 = 0;
            int out1 = 0;
            Console.Clear();

            for (cont = 1; cont <= n; cont++) {
                Console.WriteLine($"Digite o {cont}º valor: ");
                int x = int.Parse(Console.ReadLine());
                if (x>=10 && x<=20)
                    in1++;
                else
                    out1++;
                Console.Clear();
            }
            Console.WriteLine("{0} in\n{1} out", in1, out1);
        }
    }
}