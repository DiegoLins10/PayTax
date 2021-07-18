using System;
using System.Collections.Generic;
using System.Text;

namespace PayTax.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualInCome) : base(name, anualInCome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if(NumberOfEmployees > 10)
            {
                tax = 0.14;
            }
            else
            {
                tax = 0.16;
            }
            return AnualInCome * tax;
        }
    }
}
