using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise01;

namespace Excerise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to convert to words");
            string number = Console.ReadLine();
            Excerise01 excercise01 = new Excerise01();

            number = excercise01.IntegerToWords(Convert.ToUInt64(number));

            Console.WriteLine("Number in words is \n{0}", number);
            Console.ReadKey();

           
        }
    }
}
