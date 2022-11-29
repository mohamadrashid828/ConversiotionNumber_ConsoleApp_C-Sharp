using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    public class DecimalNumber
    {
         private int InputNumber;
        //public static int _InputNumber{ 
        //    set { InputNumber = value; } 
        //}

        /// <summary>
        /// constractor for get valu number 
        /// </summary>
        /// <param name="inputNumber"> input number</param>
        public DecimalNumber(int inputNumber)
        {
            this.InputNumber = inputNumber;
        }
        /// <summary>
        /// it us for convert decimal number to binery number
        /// </summary>
        /// <returns> return value is equal to string </returns>
        public string DecimalToBinery()
        {
            string Str = "";
            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 2)
            {
                a.Add(i % 2);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Str += item;
            }
            return Str;
        }
        /// <summary>
        /// it us for convert decimal number to Octal number
        /// </summary>
        /// <returns> return value is equal to string </returns>
        public string DecimalToOctal()
        {
            string Str = "";
            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 8)
            {
                a.Add(i % 8);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Str += item;
            }
            return Str;
        }
        /// <summary>
        /// it us for convert decimal number to hexadecimal number
        /// </summary>
        /// <returns> return value is equal to string </returns>
        public string DecimalToHexaDecimal()
        {
           
            string Str = "";
            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 16)
            {
                a.Add(i % 16);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Str+= BineryNmber.ChangeNumberToChar(item); 
            }
            return Str;
        }
        /// <summary>
        /// tanha bo awshuenanay ka pewist dakat digit dyari bkait bakary denit
        /// </summary>
        /// <param name="HowMonyDigit"> wour convertpr how mony digit reprresent</param>
        /// <returns> return value is equal to string </returns>
        public string DecimalToBinery(int HowMonyDigit)
        {
            HowMonyDigit = HowMonyDigit == 0 ? 1 : HowMonyDigit;
            string Str = "";
            List<int> a = new List<int>();
            int j = 1;
            for (int i = InputNumber; j <= HowMonyDigit; i /= 2)
            {
                a.Add(i % 2);
                j++;
            }
            a.Reverse();
            foreach (var item in a)
            {
                Str += item;
            }
            return Str;
        }

       ~DecimalNumber() { }
    }
}
