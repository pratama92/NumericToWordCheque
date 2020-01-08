using NumericConverter.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            string number = Console.ReadLine();
            var words = ConvertNumeric.WordsSpliter(number);
            Console.WriteLine("Output : " + words);
            Console.ReadKey();
        }                
    }
}
