﻿using System;
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
        public string DecimalToHexaDecimal()
        {
            BineryNmber bineryNmber = new BineryNmber();
            string Str = "";
            List<int> a = new List<int>();
            for (int i = InputNumber; i > 0; i /= 16)
            {
                a.Add(i % 16);
            }
            a.Reverse();
            foreach (var item in a)
            {
                Str+= bineryNmber.ChangeNumberToChar(item); 
            }
            return Str;
        }
        // tanha bo awshuenanay ka pewist dakat digit dyari bkait bakary denit
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
    }
}
