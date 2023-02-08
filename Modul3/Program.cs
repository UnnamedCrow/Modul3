using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String MyName = "Max";
            byte MyAge = 31;
            bool MyPet = true;
            double MyShoeSize = 40.5;
            Console.WriteLine("My name is {0}",MyName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do I have a pet? {0}", MyPet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);
            Console.ReadKey();
        }
    }
}
