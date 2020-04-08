using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.15.2020
 * CSC-153-0001
 * Sene Apulu
 * Falling distance calculator
 */



namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            double fallTime, //fall time in seconds
                   fallDist; //distance fell in meters
            do
            {
                Console.Clear();
                Console.WriteLine("Falling Distance Calculator");
                Console.WriteLine("---------------------------\n");
                Console.Write("enter falling time (in seconds): ");
                Double.TryParse(Console.ReadLine(), out fallTime);          //get object fall time(seconds).
                fallDist = FallingDistance(fallTime);                       //calculate fall distance(meters)
                Console.WriteLine($"\nobject fell: {fallDist} meters");     //display falling distance.

                Console.WriteLine("\n\n[enter] continue | [q] quit");       //loop break;
                userInput = Console.ReadLine();
            } while (userInput != "q");

        }
        static double FallingDistance(double seconds) 
        {
            double g = 9.8;
            double distance = .5 * (g * (seconds * seconds)); // distance = 1/2 gt^2            
            return distance;
        }
    }
}
