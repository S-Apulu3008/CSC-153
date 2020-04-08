using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxtAdventureLib;

/**
* 4.5.2020
* CSC 153
* Sene Apulu
* TextAdventure3
* Using classes to create objects for Player, Mob and Room
* objects are stored in arrays.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>(); //List for players. Player Type.
            Player myPlayer = new Player(); //Player object

            Mob[] mobs = { new Mob("Elle the Vicious", "Black LabraDane Dog"), //Mob array with Mob objects stored
                           new Mob("Black Louise", "Villain of Tragedy.") };

            Room[] rooms = { new Room("The Entrance","The Front Door.", true), //Room array with Room objects stored.
                             new Room("The Lobby", "Remove your shows please.",true),
                             new Room("The Hall","You can hear your voice echo here.", true),
                             new Room("The Ballroom", "Plenty of dancing space.", true),
                             new Room("The Study","Ssshh.", true),
                             new Room("The Parlour", "Smells like cigars in here.", false) };

            string[] weapons = { "Zweihander", "No.2 Pencil", "Super Soaker", "Table leg" };
            string[] potions = { "Little Potion", "Big Potion" };
            string[] loot = { "Golden Chalice", "Silver Bracelet", "Emerald Ring" };

            bool replay = true;


            BuildPlayer.BuildAPlayer(players); //Builds a player and adds them to the list.
            Console.ReadLine();

            do
            {
                Console.Clear();//Clear console.
                Console.WriteLine(StdMsgs.DisplayLocation(rooms, players));//Current player location.
                Console.Write(StdMsgs.MenuHeader());//Menu Header
                Console.Write(StdMsgs.MenuDisplay());//Menu Display
                switch (Console.ReadLine())
                {
                    case "1":
                        if (players[0].RoomLoc >= rooms.Length -1)//If players location is >= the length of the rooms array + 1.
                        {
                            Console.WriteLine(StdMsgs.NoMoveNorthPrompt()); //player can't move north
                            Console.ReadLine();
                            break;
                        }
                        else //else player can move north.
                        {
                            Console.WriteLine(StdMsgs.MovingNorthPrompt()); 
                            Console.ReadLine();
                            players[0].MoveToRoomNorth();
                            break;
                        }

                    case "2":
                        if (players[0].RoomLoc <= 0)//if player location is <= 0
                        {
                            Console.WriteLine(StdMsgs.NoMoveSouthPrompt());//Then player can't move south.
                            Console.ReadLine();
                            break;
                        }
                        else //else player can move north.
                        {
                            Console.WriteLine(StdMsgs.MovingSouthPrompt());
                            Console.ReadLine();
                            players[0].MoveToRoomSouth();
                            break;
                        }
                        
                    case "3":
                        Console.WriteLine(StdMsgs.ExitPrompt());
                        Console.ReadLine();
                        replay = false;//Exit do-while loop.
                        break;

                    default:
                        Console.WriteLine(StdMsgs.InvalidInputPrompt()); //Invalid input 
                        Console.ReadLine();
                        break;
                }
            } while (replay == true);

        }
    }
}
