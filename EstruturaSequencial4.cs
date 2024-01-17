using System;
using System.Globalization;


namespace ExEstruturaSequencial4
//Fazer um programa que leia o número de um funcionário,
//seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir,
//mostre o número e o salário do funcionário, com duas casas decimais.
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número do colaborador: ");
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite as horas trabalhadas do colaborador: ");
            int workedHours = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Qual o valor recebido por hora trabalhada do colaborador Nº{0}?", employeeNumber);
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();

            double employeeSalary = workedHours * hourValue;

            Console.WriteLine("Número do colaborador: {0}", employeeNumber);
            Console.WriteLine("Salário: R${0}", employeeSalary.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}