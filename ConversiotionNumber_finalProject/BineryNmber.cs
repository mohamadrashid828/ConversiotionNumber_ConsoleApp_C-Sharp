﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
    public class BineryNmber
    {
        List<char> inputNumber = new List<char>();
        /// <summary>
        /// this constractor use for  get input and reversid also iserted to arrey for the work easy
        /// </summary>
        /// <param name="inputNumber"></param>
        public BineryNmber(string inputNumber ="")
        {
            //this for used for inputnumber paramitar insert to this list with reversed 
            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                this.inputNumber.Add(inputNumber[i]);
            }
        }
        /// <summary>
        /// this method it use for convert binery number to decimal number 
        /// </summary>
        /// <returns> int</returns>
        public int BineryToDecimal()
        {
            //total is used to seve all valu adintion 
            int total = 0;
            // twan is used for to next step * 2   
            int twan = 1;
            //whith rule you must be reverse after fined
            for (int i = 0; i < inputNumber.Count; i++, twan *= 2)
            {
                if (inputNumber[i] == '1')
                {
                    total += twan;
                }

            }
            return total;
        }
        /// <summary>
        /// this method it use for convert binery number to Octal number 
        /// </summary>
        /// <returns> int</returns>
        public String BineryToOctal()
        {
            // comp bakardet bo away 3 digt 3 digt kobkatawaw la indexy era dabne dwatr revers bkain
            List<int> comp = new List<int>();
            int index = 0;
            // torenge bakardet bo away lenth war bgrit dabashy sar 3 digit 3 digit bkat 
            for (int i = 0; i < 4; i++)
            {   //total har jarau  koy 3 digit kodakatawa 
                int total = 0;
                int twan = 1;
                for (int j = 0; j < inputNumber.Count; j++, twan *= 2)
                {
                    // handek kat exepshn rudadat bahoy regi zyada am tye bo awa bakar det 
                    try
                    {
                        if (inputNumber[index] == '1')
                        {
                            total += twan;
                        }
                        index++;
                        //am ifa bo awaya katek twan gaysh ba 2 awa break loop bbi
                        if (twan >= 4)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                //am lista bo awaya ka koy 3 digit la indexek dabne 
                comp.Add(total);
            }
            comp.Reverse();         
            return String.Join("", comp);
        }
        /// <summary>
        /// this method it use for convert binery number to hexaDecimal number 
        /// </summary>
        /// <returns> int</returns>
        public String BineryToHxadicimal()
        {
            // comp bakardet bo away 4 digt 4 digt kobkatawaw la indexy era dabne dwatr revers bkain
            List<String> comp = new List<String>();
            int index = 0;
            // torenge bakardet bo away lenth war bgrit dabashy sar 4 digit 4 digit bkat 
            for (int i = 0; i < 4; i++)
            {   //total har jarau  koy 4 digit kodakatawa 
                int total = 0;
                int twan = 1;
                for (int j = 0; j < inputNumber.Count; j++, twan *= 2)
                {
                    // handek kat exepshn rudadat bahoy regi zyada am tye bo awa bakar det 
                    try
                    {
                        if (inputNumber[index] == '1')
                        {
                            total += twan;
                        }
                        index++;
                        //am ifa bo awaya katek twan gaysh ba 3 awa break loop bbi
                        // la hexa dabi la 1 hata twan 3 bchit ka 2 twan 3 dakata 8 agar yaksan bu awa brek bbi
                        if (twan >= 8)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                //am lista bo awaya ka koy 4 digit la indexek dabne 
                // hamuy wak octala tanha away jiawaza dabe la zhmara 10 baraw sarawa bkait ba pit ta 15
                comp.Add(ChangeNumberToChar(total));
            }
            comp.Reverse();
            return String.Join("", comp);
        }
        /// <summary>
        /// becouse of hexanumber consists of number and charector we nedd change number to char such(A,B,C..)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
       public static String ChangeNumberToChar(int num)
        {
            return num switch
            {
                10 => "A",
                11 => "B",
                12 => "C",
                13 => "D",
                14 => "E",
                15 => "F",
                _ => num.ToString(),
            };
        }
        ~BineryNmber() { }
    }
}
