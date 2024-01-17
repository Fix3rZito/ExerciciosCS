using System;

namespace EstruturaCondicional6
    //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
    //de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o
    //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).

    //Se o ponto estiver na origem, escreva a mensagem “Origem”.
    //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva dois pontos cartesianos:");
            string[] vet = Console.ReadLine().Split(' ');
            double pontoX = double.Parse(vet[0]);
            double pontoY = double.Parse(vet[1]);

            if (pontoX > 0 && pontoY > 0)
                Console.WriteLine("Q1");

            else if (pontoX < 0 && pontoY > 0)
                Console.WriteLine("Q2");

            else if (pontoX < 0 && pontoY < 0)
                Console.WriteLine("Q3");

            else if (pontoX > 0 && pontoY < 0)
                Console.WriteLine("Q4");

            else if (pontoX == 0)
                Console.WriteLine("Eixo X");

            else if (pontoY == 0)
                Console.WriteLine("Eixo Y");

            else if (pontoX == 0 && pontoY == 0)
                Console.WriteLine("ORIGEM");



        }
    }
}