using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Anders", 1);
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
