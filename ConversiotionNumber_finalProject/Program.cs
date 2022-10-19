using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpperInvariant();
            //BineryNmber test = new BineryNmber(input);
            //Console.WriteLine(test.BineryToHxadicimal());
            HexaNumber test = new HexaNumber(input);
            Console.WriteLine(test.HexaDicimalToOctal());



        }
      
    }
}
