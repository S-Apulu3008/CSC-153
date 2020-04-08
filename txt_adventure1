using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1.29.2020
 CSC 153
 Sene Apulu
 Text adventure attempt. Using arrays and lists to create a linear dungeon crawl.

 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = { "Entrance", "Lobby", "Hall", "Ballroom", "Study", "Parlour" };
            string[] weapons = { "Zweihander", "No.2 Pencil", "Super Soaker", "Table leg" };
            string[] potions = { "Little Potion", "Big Potion" };
            string[] treasure = { "Golden Chalice", "Silver Bracelet", "Emerald Ring" };

            List<string> items = new List<string>();
            items.Add("Little key");
            items.Add("Big Key");
            items.Add("Screwdriver");
            items.Add("Magnifying Glass");

            List<string> mobs = new List<string>();
            mobs.Add("June the Rager");
            mobs.Add("Bad Boy Gadbois");
            mobs.Add("Black Louise");
            mobs.Add("Elle the Vicious");
            mobs.Add("Pai Mei");

            bool replay = true;
            while (replay)
            {   
                Console.Clear();
                Console.WriteLine("Main Menu" +
                    "\n1. Display Rooms\n2. Display Weapons\n3. Display Potions\n4. Display Treasure" +
                    "\n5. Display Items\n6. Display Mobs\n7. Play\n8. Exit");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "rooms":
                        Console.WriteLine("Display rooms!\n");
                        displayArray(rooms);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "2":
                    case "weapons":
                        Console.WriteLine("Display weapons!\n");
                        Array.Sort(weapons);
                        displayArray(weapons);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "3":
                    case "potions":
                        Console.WriteLine("Display potions!\n");
                        displayArray(potions);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "4":
                    case "treasure":
                        Console.WriteLine("Display treasure!\n");
                        displayArray(treasure);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "5":
                    case "items":
                        Console.WriteLine("Display items!\n");
                        displayList(items);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "6":
                    case "mobs":
                        Console.WriteLine("Display mobs!\n");
                        displayList(mobs);
                        Console.WriteLine("\nPress [ENTER] to return to Menu.");
                        Console.ReadLine();
                        break;

                    case "7":
                    case "play":
                        Console.WriteLine("Play game!\n");
                        playGame();
                        Console.ReadLine();
                        break;

                    case "8":
                    case "exit":
                        Console.WriteLine("Exit program.");
                        Console.ReadLine();
                        replay = false;
                        break;

                    default:
                        Console.WriteLine("Make a selection from the menu.\nPress [ENTER]");
                        Console.ReadLine();
                        break;
                }
            }

            void playGame()
            {
                bool play = true;
                int room = 0;
                while (play)
                {
                    Console.Clear();
                    Console.WriteLine($"Current Location = 'The {rooms[room]}'");//Player starts at 'Entrance'
                    Console.WriteLine("(N)orth, (S)outh\n'(R)ooms' to display rooms.");
                    Console.WriteLine("'Exit' to exit.");
                    switch(Console.ReadLine().ToLower()) 
                    {
                        case "n":
                        case "north":
                            Console.Clear();
                            room++; //When user moves North the index increments by 1.
                            if (room > rooms.Length - 1) //If statement prevents out of index range error.
                            {
                                room--;
                                Console.WriteLine("You cannot go any further North.");
                                Console.ReadLine();
                                break;
                            }
                            Console.WriteLine("You moved North.");
                            Console.WriteLine("[ENTER]");
                            Console.ReadLine();
                            break;
                        case "s":
                        case "south":
                            Console.Clear();
                            room--; //When user moves South the index decrements by 1.
                            if (room < 0) //If statement prevents out of index range error.
                            {
                                room++;
                                Console.WriteLine("You cannot go any further South.");
                                Console.ReadLine();
                                break;
                            }
                            Console.WriteLine("You moved South.");
                            Console.WriteLine("[ENTER]");
                            Console.ReadLine();
                            break;
                        case "rooms": //user can see the names of rooms.
                        case "r":
                            Console.Clear();
                            displayArray(rooms);
                            Console.ReadLine();
                            break;

                        case "exit": //User can exit
                            play = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice\nPress [ENTER]");
                            Console.ReadLine();
                            break;
                    }
                
                }
            }

            void displayArray(string[] anArray)//This method will iterate over a string array using a foreach loop.
            {
                foreach(var item in anArray)
                {
                    Console.WriteLine(item);
                }
            }

            void displayList(List<string> aList)//This method will iterate over a string list using a foreach loop.
            {
                foreach (var item in aList)
                {
                    Console.WriteLine(item);
                }            
            }
            
           
        }//End main
    }//End Class
}
