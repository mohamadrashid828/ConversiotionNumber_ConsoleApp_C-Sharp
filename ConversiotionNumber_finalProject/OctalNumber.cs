using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    public class OctalNumber 
    {

        List<int> inputNumber = new List<int>();
        /// <summary>
        /// it used for get input to string and revers it and conver to list int
        /// </summary>
        /// <param name="inputNumber1"> input value must be string</param>
        public OctalNumber(string inputNumber1)
        {
            //this for used for inputnumber paramitar insert to this list with reversed 
            for (int i = inputNumber1.Length-1; i >= 0; i--)
            {
                // temp bakardet bo gorine charaktor bo int 
                int temp = (int)(inputNumber1[i] - '0');
                inputNumber.Add(temp);
            }
        }
        /// <summary>
        /// it us for convert Octal number to Dicimal number
        /// </summary>
        /// <returns> return value is equal to double </returns>
        public double OctalToDicimal()
        {   // koy anjam 
            double DicimalNum = 0;
            for (int i = 0; i < this.inputNumber.Count; i++)
            {
                double power = Math.Pow(8, i);
                DicimalNum += power * inputNumber[i];
            }
            return DicimalNum;  
        }
        /// <summary>
        /// it us for convert Octal number to Binery number 
        /// </summary>
        /// <returns> return value is equal to String </returns>
        public string OctalToBinery( )
        {   // koy anjam 
            List<string> total_valu_binery = new List<string>();

            for (int i = 0; i < this.inputNumber.Count; i++)
            {
                DecimalNumber n = new DecimalNumber(inputNumber[i]);
                total_valu_binery.Add(n.DecimalToBinery(3));
            }
            total_valu_binery.Reverse();
            //gorine list bo string
            string ListChangeToString = "";
            foreach (var item in total_valu_binery)
            {
                ListChangeToString+=item;
            }
            return ListChangeToString;
        }
        /// <summary>
        /// it us for convert Octal number to HEXADICIMAL number 
        /// </summary>
        /// <returns> return value is equal to String </returns>
        public string OctalToHexaDicemal()
        {
            string binery = OctalToBinery();
            BineryNmber Object_binery =new BineryNmber(binery);
            return Object_binery.BineryToHxadicimal(); 
        }

        ~OctalNumber()
        {
        }
    }
}
