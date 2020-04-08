using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Date
* CSC 153
* 3.18.2020
* Car Class
*/
namespace myClassLib
{
    public class Car
    {
        private int _year;
        private string _make;
        private int _speed;

        public Car()
        {
            Year = 0;
            Make = "";
            Speed = 0;
            CarCount++;
        }

        public Car(int year, string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
            CarCount++;
        }

        //Properties
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public void Accelerate()
        {
            Console.WriteLine(myClassLib.StdMsgs.ShowAccelPrompt());
            Speed += 5;
        }

        public void Brake()
        {
           ; //Decrease speed.
            if (Speed < 5) //Check if speed is lt 5
            {
                Speed = 0;
                Console.WriteLine(StdMsgs.DisplayStopPrompt()); //if it is DisplayStopPrompt.
            }
            else
            {
                Console.WriteLine(myClassLib.StdMsgs.ShowBrakePrompt());//Otherwise car is braking
                Speed -= 5;
            }
        }
        public static int CarCount { get; set; } = 0;
    }
}
