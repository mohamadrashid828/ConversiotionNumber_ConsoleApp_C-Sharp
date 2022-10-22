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
            //string input = Console.ReadLine().ToUpperInvariant();
            //BineryNmber test = new BineryNmber(input);
            //Console.WriteLine(test.BineryToHxadicimal());
            //HexaNumber test = new HexaNumber(input);
            //Console.WriteLine(test.HexaDicimalToOctal());
            String z = "01010101";
            var x = Console.Read();
            Console.WriteLine(CheckBineryInput(z));
            int InputFrom, InputTo ;
            Console.WriteLine("                                              Number converstion");
           
        a:
            try
            {
                InputFrom= listMenu("From");
                InputTo= listMenu("To  ");
            }
            catch (Exception)
            {
                Console.WriteLine(" please Just input number no String and simbul and char");
             goto a;
            }
            string inputValu = Console.ReadLine();
            switch (InputFrom)
            {
                case 1:
                    if (CheckBineryInput(inputValu))
                    {
                    BineryNmber b = new BineryNmber(inputValu);
                    switch (InputTo)
                    {
                        case 1:
                     
                            Console.WriteLine(inputValu);
                            break;
                        case 2:
                            Console.WriteLine(b.BineryToOctal());
                            break;
                        case 3:
                            Console.WriteLine(b.BineryToDecimal());
                            break;
                        case 4:
                            Console.WriteLine(b.BineryToHxadicimal());
                            break;
                        default:
                            Console.WriteLine("please just input number (1,2,3,4) ");
                            break;
                    }
                    }
                    else
                    {
                        Console.WriteLine("please for bineryNumber just input 0 or 1");
                    }
                    break;
                case 2:
                    if (CheckOctalInput(inputValu))
                    {

                   
                    OctalNumber Oj_Octal = new OctalNumber(inputValu);
                    switch (InputTo)
                    {
                        case 1:
                            Console.WriteLine(Oj_Octal.OctalToBinery());
                            break;
                        case 2:
                            Console.WriteLine(inputValu);
                            break;
                        case 3:
                            Console.WriteLine(Oj_Octal.OctalToDicimal());
                            break;
                        case 4:
                            Console.WriteLine(Oj_Octal.OctalToHexaDicemal());
                            break;
                        default:
                            Console.WriteLine("please just input number (1,2,3,4) ");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("please just input number bettwen 0 to 7");
                    }
                    break;
                case 3:
                    DecimalNumber Oj_Decimal = new DecimalNumber(int.Parse(inputValu));
                    switch (InputTo)
                    {
                        case 1:
                            Console.WriteLine(Oj_Decimal.DecimalToBinery());
                            break;
                        case 2:
                            Console.WriteLine(Oj_Decimal.DecimalToOctal());
                            break;
                        case 3:
                            Console.WriteLine(inputValu);
                            break;
                        case 4:
                            Console.WriteLine(Oj_Decimal.DecimalToHexaDecimal());
                            break;
                        default:
                            Console.WriteLine("please just input number (1,2,3,4) ");
                            break;
                    }
                    break;
                case 4:
                    HexaNumber Oj_hexaDicemal = new HexaNumber(inputValu);
                    switch (InputTo)
                    {
                        case 1:
                            Console.WriteLine(Oj_hexaDicemal.HexaDicimalToBinery());
                            break;
                        case 2:
                            Console.WriteLine(Oj_hexaDicemal.HexaDicimalToOctal());
                            break;
                        case 3:
                            Console.WriteLine(Oj_hexaDicemal.HexaDicimalToDicimal());
                            break;
                        case 4:
                            Console.WriteLine(inputValu);
                            break;
                        default:
                            Console.WriteLine("please just input number (1,2,3,4) ");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("please just input number (1,2,3,4) ");
                    break;
            }

        }
        static int listMenu(string Str)
        {
            Console.WriteLine($"{Str}:   1- Binery");
            Console.WriteLine("        2- Octal");
            Console.WriteLine("        3- Decimal");
            Console.WriteLine("        4- HexaDecimal");
            Console.Write("your chooes : ");
         return int.Parse(Console.ReadLine());
        }
        static bool CheckBineryInput(string Str)
        {
            bool resolt = true;

            foreach (var item in Str)
            {
 
                if (true &&(item != '0' || item != '1'))
                {
                    resolt = false;
                    break;
                }
               
            }
            return resolt;  
        }
        static bool CheckOctalInput(string Str)
        {
            bool resolt = true;
            foreach (var item in Str)
            {
                if (item <0  || item >7)
                {
                    resolt = false;
                }
            }
            return resolt;
        }

    }
}
