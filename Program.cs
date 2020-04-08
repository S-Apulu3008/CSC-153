using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 1.24.2020
* CSC 153
* Sene Apulu
* Age List program gets ages from user, adds them to a list,
* displays them back and calculates average of the ages.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            bool replay = true;
            while (replay)
            {
                Console.Clear();
                //Ask the user to run the age program or exit the program
                Console.WriteLine("Age List Program | M2HW2_Apulu8050");
                Console.WriteLine();
                Console.WriteLine("1.) Run Age Program\n2.) Exit");

                //Get the user's response.                
                switch (Console.ReadLine())
                {
                    case "1":
                        Ages(); //Call the ages method
                        Console.WriteLine("Press Enter to return to menu.");
                        Console.ReadLine();
                        break;
                    case "2":
                        replay = false;
                        Console.WriteLine("User exits program.\nPress Enter.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Make a selection from the menu.\nPress enter.");
                        Console.ReadLine();
                        break;
                }
            }

        }
        public static void Ages()
        {
            //Ask the user how many ages the user wants to input
            Console.Clear();
            Console.WriteLine("Ages Program runs.");
            Console.WriteLine("How many ages do you want to input?");

            //var numAges is amount of ages the user wants to enter.
            int numAges = int.Parse(Console.ReadLine());

            //Collect the ages and add them to a list.
            List<String> ageList = new List<String>();
            for (int count = 0; count < numAges; count++)
            {
                Console.Write($"Enter age { count + 1 }: ");
                ageList.Add(Console.ReadLine());           
            }

            //Display all the ages the user inputed
            Console.Write($"You entered: ");
            double ageTotal = 0;
            for (int i = 0; i < numAges; i++)
            {
                Console.Write($"{ ageList[i] } ");
                ageTotal += double.Parse(ageList[i]);
            }

            Console.WriteLine();

            //Display the average age of the list
            double ageAvg = ageTotal / numAges;
            Console.WriteLine($"Average of age(s) entered:  { Math.Round(ageAvg,2) }\n");

        }
    }
}
