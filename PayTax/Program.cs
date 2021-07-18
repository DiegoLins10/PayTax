using PayTax.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PayTax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i<num; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualInCome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double Health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(Health, name, anualInCome));

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualInCome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(emp, name, anualInCome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach(TaxPayer l in list)
            {
                Console.WriteLine($"{l.Name} $ {l.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum = sum + l.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
