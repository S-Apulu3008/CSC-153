using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1.22.2020
 * CSC 153
 * Sene Apulu
 * displaying values from an array
 * M2HW1_apulus8050
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = { 1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36 }; //Hard coded values in an array.
            for (int i = 0; i < sales.Length; i++) //for loop iterates over the array. The .Length returns the length of the array.
            {
                Console.WriteLine(sales[i]);//Display sales with index.
            }
            Console.ReadLine();//Prevent the window from closing.
        }
    }
}
