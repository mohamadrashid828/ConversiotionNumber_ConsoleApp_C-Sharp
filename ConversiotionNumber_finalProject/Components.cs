using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
     class Components
    {
        protected int listMenu(string Str)
        {
        minu:
            Console.WriteLine($"{Str}:   1- Binery");
            Console.WriteLine("        2- Octal");
            Console.WriteLine("        3- Decimal");
            Console.WriteLine("        4- HexaDecimal");
            Console.Write("your chooes : ");
            int input = int.Parse(Console.ReadLine());
            if (!(input >= 1 && input <= 4))
            {
                Console.WriteLine("please just input number (1,2,3,4) ");
                goto minu;
            }
            return input;
        }
        /// <summary>
        /// it used for chek input number is this binery or nobinery if input number not 0 or 1 return false else true
        /// </summary>
        /// <param name="Str"> input valu </param>
        /// <returns></returns>
        protected bool CheckBineryInput(string Str)
        {
            bool resolt = true;

            foreach (var item in Str)
            {

                if (item == '0' || item == '1')
                {
                    continue;

                }
                else
                {
                    resolt = false;
                    return resolt;
                }

            }
            return resolt;
        }
        /// <summary>
        /// it used for check inbut if input between 0 and 7 return true else false
        /// </summary>
        /// <param name="Str"> input value </param>
        /// <returns></returns>
        protected bool CheckOctalInput(string Str)
        {
            bool resolt = true;
            foreach (var item in Str)
            {
                int char_to_int = (int)Char.GetNumericValue(item);
                if (char_to_int >= 0 && char_to_int <= 7)
                {
                    continue;
                }
                else
                {
                    resolt = false;
                    return resolt;
                }
            }
            return resolt;
        }
    }
}
