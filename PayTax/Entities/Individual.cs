using System;
using System.Collections.Generic;
using System.Text;

namespace PayTax.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualInCome) : base(name, anualInCome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
           double tax;
           if(AnualInCome <= 20000.0)
            {
                tax = 0.15; 
            }
            else
            {
                tax = 0.25;
            }
            return (AnualInCome * tax) - (HealthExpenditures * 0.50);
        }
    }
}
