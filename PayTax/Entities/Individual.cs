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
            if (AnualInCome <= 20000.0)
            {
                return (AnualInCome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualInCome * 0.25) - (HealthExpenditures * 0.50);
            }

        }
    }
}
