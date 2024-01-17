using System;

namespace EstruturaCondicional4 {
    //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
    //sabendo que o mesmo pode começar em um dia e terminar em outro,
    //tendo uma duração mínima de 1 hora e máxima de 24 horas.
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva a hora inicial e a hora final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(vet[0]);
            int hora2 = int.Parse(vet[1]);
            int horaTotal;

            if (hora1 > hora1 || hora1 == hora2) {
                horaTotal = 24 - hora1 - hora2;
                Console.WriteLine($"O JOGO DUROU {horaTotal} HORA(S)");
            }
            else {
                horaTotal = 24 - (24 + hora1 - hora2);
                Console.WriteLine($"O JOGO DUROU {horaTotal} HORA(S)");
            }

        }
    }
}
