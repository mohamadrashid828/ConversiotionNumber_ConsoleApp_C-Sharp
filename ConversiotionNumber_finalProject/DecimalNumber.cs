using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    internal class DecimalNumber
    {
     private int InputNumber;
      public  DecimalNumber(int inputNumber)
        {
            this.InputNumber = inputNumber;
        }
        public void DecimalToBinery()
        {
           
            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 2)
            {
                a.Add(i % 2);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public void DecimalToOctal()
        {

            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 8)
            {
                a.Add(i % 8);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public void DecimalToHexaDecimal()
        {

            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 16)
            {
                a.Add(i % 16);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
