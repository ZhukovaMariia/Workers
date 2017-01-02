using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class GoodEmployee : Employee
    {
        public decimal Oklad { get; private set; }
        public GoodEmployee(string name, int age, decimal oklad) : base(name, age)
        {
            Oklad = oklad;
            GetSalary = Salary();
        }

        public override decimal GetSalary { get; set; }
        
            

        protected override decimal Salary()
        {
            return Oklad;
        }
    }
}
