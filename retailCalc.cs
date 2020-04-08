using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2.15.2020
 * csc-153-0001
 * sene apulu
 * calulate the retail price from the wholesale price.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool   replay = true;   //sentry
            double markUp = 0,      //start markup percent
                   wholeSale,       //wholesale price
                   retail;          //retail price

            while (replay)
            {
                Console.Clear();    //Clear Screen and Display Menu
                Console.WriteLine("retail price calculator");
                Console.Write("-----------------------" +
                              "\n1. adjust markup percentage" +
                              "\n2. calculate retail" +
                              "\n3. exit" +
                              "\n>");
                switch (Console.ReadLine())
                {
                    case "1":   //Adjust markup. Startup markup percent is 0%
                        Console.Write($"current markup: [{markUp}%]" +
                                       "\nnew markup: ");
                        Double.TryParse(Console.ReadLine(), out markUp);
                        Console.Write($"markup updated: [{markUp}%]");   //Display new markup
                        Console.ReadLine();
                        break;

                    case "2": //Calculate Retail.
                        Console.Write("enter wholesale cost: ");        
                        Double.TryParse(Console.ReadLine(), out wholeSale); //Get Retail
                        retail = CalculateRetail(wholeSale, markUp);        //Calculate Retail
                        Console.Write($"retail cost: ${retail}");           //Display Retail
                        Console.ReadLine();
                        break;

                    case "3":
                        replay = false; //exits while-loop
                        break;

                    default:    //invalid case inputs will just loop back to menu.
                        break;
                }//end switch

            }//end while

        }//end main

        static double CalculateRetail(double wholeSaleCost, double markupPercent)
        {   
            /*
                Divide the markupPercent by 100 to convert to decimal.
                Multiply markupPercent by the wholeSaleCost and then
                add that to the wholesale to get retail price.
            */
            double retailPrice = wholeSaleCost + (wholeSaleCost * (markupPercent/100));
            return retailPrice;
        }//end CalculateRetail method

    }//end class
    
}//end namespace
