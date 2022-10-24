using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    internal class HexaNumber
    {
        List<int> inputNumber = new List<int>();
       
        public HexaNumber(string inputNumber1)
        {
            //this for used for inputnumber paramitar insert to this list with reversed 
            for (int i = inputNumber1.Length - 1; i >= 0; i--)
            {
                // temp bakardet bo gorine charaktor bo int 
               inputNumber.Add(ChangCharTOnumber(inputNumber1[i].ToString()));
               
            }
        }
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
        public string HexaDicimalToBinery()
        {
            List<int> total_valu_binery = new List<int>();
            for (int i = 0; i < this.inputNumber.Count; i++)
            {
                for (int j = inputNumber[i]; j > 0; j /= 2)
                {
                    total_valu_binery.Add(j % 2);
                }
            }
            total_valu_binery.Reverse();
            //gorine list bo string
            string ListChangeToString = "";
            foreach (var item in total_valu_binery)
            {
                ListChangeToString += item.ToString();
            }
            return ListChangeToString;

        }
         public string HexaDicimalToOctal()
        {
          string binery=  HexaDicimalToBinery();
            BineryNmber by_num = new BineryNmber(binery);
            return by_num.BineryToOctal();
        }

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
    }
}
