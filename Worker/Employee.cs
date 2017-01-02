using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    [Serializable]
    abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract decimal GetSalary { get; set; }

        protected Employee(string name, int age)
            {
            Name = name;
            Age = age;
            }
        protected abstract decimal Salary();
        public override string ToString()
        {
            return Name+" "+Age+" "+" "+Salary();
        }

    }
}
