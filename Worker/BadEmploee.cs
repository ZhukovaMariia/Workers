using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    [Serializable]
    sealed class BadEmploee : Employee
    {
        public double Stavka { get; private set; }
        public BadEmploee(string name, int age, double stavka) : base(name, age)
        {
            Stavka = stavka;
            GetSalary = Salary();
        }

        public override decimal GetSalary { get; set; }
            

        protected override decimal Salary()
        {
            return (decimal)(20.8 * 8 * Stavka);
        }
    }
}
