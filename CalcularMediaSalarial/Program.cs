using System;

namespace CalcularMediaSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment employee1 = new Payment();
            Payment employee2 = new Payment();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Média salária: {((employee1.Salary+employee2.Salary)/2).ToString("f2")}");
        }
    }
}
