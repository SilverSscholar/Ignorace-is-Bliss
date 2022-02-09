using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorace_is_Bliss
{
    class Interactions
    {

        //Interaction Generic


        //Interactions
        public static void FirstInteraction() //function won't return variable if void
        {
            Console.WriteLine("You stare sleepily back at your mother ...");
            Console.WriteLine("She looks at you expectantly...");
            Console.ReadKey();

        }


        //Options
        public static void Options(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h > 0)
            {
                Console.WriteLine("======================");
                Console.WriteLine("| (I)nvestigate  (C)ry |");
                Console.WriteLine("|  (R)eason  (B)lock   |");
                Console.WriteLine("| (E)at        (F)lee  |");
                Console.WriteLine("======================");
                Console.WriteLine("Food " + Program.currentPlayer.food + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower()== "i" || input.ToLower()== "investigate")
                {
                    //investigate the encounter
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your " +n+ " looks at you, expectantly.");
                    Console.WriteLine($"It's been hours since she picked you up from your father's and the road is still endless. \n");
                    Console.WriteLine($"She looks exhausted herself.");
                }
                else if (input.ToLower() == "c" || input.ToLower()== "cry")
                {
                    //cry try to win the enemies sympathy with your tears
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You start sniffling, you're exhausted from being on the road this long. You just wanna go home. \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your " +n+ "looks are you worriedly.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Heavy tears start falling loosly on your cheeks as you hiccup.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"It's okay honey we'll be home soon I promise.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You wipe your tears on your sleeve drying your face as you both continue the journey in silence.");


                }
                
                else if (input.ToLower() == "r" || input.ToLower() == "reason")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You tell your mom that you hope that you arrive home soon, and that your starving.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"You notice your mother's eyes grow wide as you look at the front mirror. You swear you hear her mumble a curse under her breathe. \n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"'Hey, baby look in your travel bag I think I packed a few snacks for you.'");
                    //figure out a way to have the character actually recieve the items to put in his pocket/bag
                }
                else if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    //block use on an enemy that just won't let up
                }
                else if (input.ToLower() == "e" || input.ToLower() == "eat")
                {
                    //eat to regain health, it'll be fine monsters are polite enough to wait for the next turn
                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    //flee fleeing is sometimes the best option when your a scared 5 yr old
                    //fleeing has a % chance of failing, or has a chance encounter of the monster pursuing (if i can figure that out)
                }
            }
        }
    }
}
