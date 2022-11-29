using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiotionNumber_finalProject
{
     class Switch:Components
    {


        public Switch()
        {
            int InputFrom, InputTo;
            Console.WriteLine("                                              Number converstion");
            Console.WriteLine("NOTE: Whenever you wont to back to listmenu write (menu) or (*)");
        star_Listminu:
            try
            {
                InputFrom = listMenu("From");
                InputTo = listMenu("To  ");
            }
            catch (Exception)
            {
                Console.WriteLine(" please Just input number no String and simbul and char");
                goto star_Listminu;
            }
            while (true)
            {
                Console.Write("input your number : ");
                string inputValu = Console.ReadLine().ToUpperInvariant();
                if (inputValu == "menu" || inputValu == "*")
                    goto star_Listminu;
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
                            }
                        }
                        else
                        {
                            Console.WriteLine("please just input number bettwen 0 to 7");
                        }
                        break;
                    case 3:
                        // for just input number no charector
                        try
                        {
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
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("pelease for number just input number not char or smbule");
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
                        }
                        break;

                }

            }

        }


    }
}
