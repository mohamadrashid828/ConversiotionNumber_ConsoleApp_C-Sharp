using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConversiotionNumber_finalProject
{
     class HexaNumber 
    {
        List<int> inputNumber = new List<int>();  
        /// <summary>
        /// it used for get input valu and reverced and convert to char with rulle hexa number
        /// </summary>
        /// <param name="inputNumber1"> input value</param>
        public HexaNumber(string inputNumber1)
        {
            //this for used for inputnumber paramitar insert to this list with reversed 
            for (int i = inputNumber1.Length - 1; i >= 0; i--)
            {
                // temp bakardet bo gorine charaktor bo int 
               inputNumber.Add(ChangCharTOnumber(inputNumber1[i].ToString()));
               
            }
        }
        /// <summary>
        /// it uset for convert hexadicemal to Dicemal
        /// </summary>
        /// <returns>always return double</returns>
        public double HexaDicimalToDicimal()
        {
            double DicimalNum = 0;
            for (int i = 0; i < this.inputNumber.Count; i++)
            {
                double power = Math.Pow(16, i);
                DicimalNum += power * inputNumber[i];
            }
            return DicimalNum;
        }
        /// <summary>
        /// it uset for convert hexadicemal to binery number
        /// </summary>
        /// <returns>always return String</returns>
        public string HexaDicimalToBinery()
        {
            string resolt = "";
            List<string> inputNumber1 = new List<string>();
            for (int i = 0; i < inputNumber.Count; i++)
            {

                DecimalNumber d = new DecimalNumber(inputNumber[i]);
                inputNumber1.Add( d.DecimalToBinery(4));
            }
            inputNumber1.Reverse();
            for (int i = 0; i < inputNumber.Count; i++)
            {
                resolt += inputNumber1[i];
            }
            return resolt;

        }
        /// <summary>
        /// it uset for convert hexadicemal to binery octal number with rule connot convert hexa to octal to directly
        /// </summary>
        /// <returns>always return String</returns>
        public string HexaDicimalToOctal()
        {
           string a= HexaDicimalToDicimal().ToString();
            DecimalNumber e = new DecimalNumber(int.Parse(a));
           return e.DecimalToOctal();
        }
        /// <summary>
        /// it used for change char to number becouse hexa number some tims can charector
        /// </summary>
        /// <param name="num"> input your char</param>
        /// <returns> int </returns>
        static int ChangCharTOnumber(string num)
        {
            switch (num)
            {
                case "A":
                    return 10;
                case "B":
                    return 11;
                case "C":
                    return 12;
                case "D":
                    return 13;
                case "E":
                    return 14;
                case "F":
                    return 15;
                default:
                    return int.Parse(num);
            }
        }
        ~HexaNumber()
        {
        }
    }
}
