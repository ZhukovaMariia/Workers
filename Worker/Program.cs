using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new BadEmploee("Petrov", 36, 250),
                new BadEmploee("Ivanov", 44, 628.68),
                new BadEmploee("Sidorov", 21, 140),
                new GoodEmployee("Ostapov", 36, 56000),
                new GoodEmployee("Zuev", 52, 32000)
            };

            var punktA = emp.OrderBy(a => a.GetSalary);
            foreach (var e in punktA)
                Console.WriteLine(e);
                    Console.Write(new string('*', 20));

           
            foreach (var e in punktA.Take(5))
                Console.WriteLine(e);
            Console.Write(new string('-', 20));

            foreach (var e in punktA.Take(3))
                Console.WriteLine(e.Name);

            var binary = new BinaryFormatter();

            using (var fs = new FileStream("data.dat", FileMode.Create))
            {
                binary.Serialize(fs, emp);

            }

            try
            {
                var res = binary.Deserialize(File.Open("data.dat", FileMode.Open)) as List<Employee>;
                foreach (var e in res)
                    Console.WriteLine(e);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();

            }
            Console.ReadKey();
        }
    }
}
