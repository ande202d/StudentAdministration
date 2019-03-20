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
            Student s2 = new Student("Jacob", 2);
            Student s3 = new Student("Mikkel", 3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.ReadKey();
        }
    }
}
