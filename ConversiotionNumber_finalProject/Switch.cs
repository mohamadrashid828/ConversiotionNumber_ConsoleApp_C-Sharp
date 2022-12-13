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
                Console.WriteLine($" **********************************************convert {get_name(InputFrom)} number to {get_name(InputTo)} number ");
            }
            catch (Exception)
            {
                Console.WriteLine(" please Just input number no String and simbul and char");
                goto star_Listminu;
            }
            while (true)
            {
                Console.Write($"input {get_name(InputFrom)} number : ");
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
                                    preint_resolt(inputValu, inputValu, get_name(InputFrom), get_name(InputTo));
                                  
                                    break;
                                case 2:
                                    preint_resolt(b.BineryToOctal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                     break;
                                case 3:
                                    preint_resolt(b.BineryToDecimal(), inputValu, get_name(InputFrom), get_name(InputTo));                        
                                    break;
                                case 4:
                                    preint_resolt(b.BineryToHxadicimal(), inputValu, get_name(InputFrom), get_name(InputTo));
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
                                    preint_resolt(Oj_Octal.OctalToBinery(), inputValu, get_name(InputFrom), get_name(InputTo));                        
                                    break;
                                case 2:
                                    preint_resolt(inputValu, inputValu, get_name(InputFrom), get_name(InputTo));
                                   
                                    break;
                                case 3:
                                    preint_resolt(Oj_Octal.OctalToDicimal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                  
                                    break;
                                case 4:
                                    preint_resolt(Oj_Octal.OctalToHexaDicemal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    
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
                                    preint_resolt(Oj_Decimal.DecimalToBinery(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 2:
                                    preint_resolt(Oj_Decimal.DecimalToOctal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 3:
                                    preint_resolt(inputValu, inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 4:
                                    preint_resolt(Oj_Decimal.DecimalToHexaDecimal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("pelease for number just input number not char or smbule");
                        }
                        break;
                    case 4:
                        try
                        {
                            HexaNumber Oj_hexaDicemal = new HexaNumber(inputValu);
                        
                            switch (InputTo)
                            {
                                case 1:
                                    preint_resolt(Oj_hexaDicemal.HexaDicimalToBinery(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 2:
                                    preint_resolt(Oj_hexaDicemal.HexaDicimalToOctal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 3:
                                    preint_resolt(Oj_hexaDicemal.HexaDicimalToDicimal(), inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                                case 4:
                                    preint_resolt(inputValu, inputValu, get_name(InputFrom), get_name(InputTo));
                                    break;
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("please just input number or char  A,B,C,D,E,F ");
                        }
                        break;

                }

            }

        }


    }
}
