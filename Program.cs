using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2.17.2020
 * CSC 153
 * Sene Apulu
 * Text Adventure 2
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = { "Entrance", "Lobby", "Hall", "Ballroom", "Study", "Parlour" };
            int roomNumber = 0;//Starting room number
            int dmg; 
            bool replay = true;
            while (replay)
            {
                Console.Clear();
                StandardMsg.DisplayPrompt($"Current Location is: {rooms[roomNumber]}");//current location.
                StandardMsg.DisplayMenuPrompt();
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        MoveNorth(ref roomNumber, rooms);//room number passed by reference
                        break;
                    case 2:
                        MoveSouth(ref roomNumber, rooms);//room number passed by reference
                        break;
                    case 3:
                        dmg = Attack();
                        StandardMsg.DisplayPrompt($"{dmg} DMG dealt!");//Display dmg
                        Console.ReadLine();
                        break;
                    case 4:
                        replay = false;
                        StandardMsg.DisplayExitPrompt();
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void MoveNorth(ref int room, string[] dungeon) 
        {
            room++;
            Console.WriteLine(dungeon.Length);
            if (room > dungeon.Length - 1) //prevent stepping out of array.
            {
                room--;
                StandardMsg.CantGoNorthPrompt();
                Console.ReadLine();
            }    
        }

        public static void MoveSouth(ref int room, string[] dungeon)
        {
            room--;
            if (room < 0)//prevent stepping out of array.
            {
                room++;
                StandardMsg.CantGoSouthPrompt();
                Console.ReadLine();
            }
        }

        public static int Attack() 
        {
            var rand = new Random();
            int dmg = rand.Next(1, 20);//return dmg between 1 and 20.
            return dmg;
        }
    }
}