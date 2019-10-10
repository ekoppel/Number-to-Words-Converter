using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be turned to English");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumberConversions.Convert(input));
            Console.ReadKey();
        }
    }
}