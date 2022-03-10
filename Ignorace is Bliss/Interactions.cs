using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorace_is_Bliss
{
    class Interactions
    {
        static Random rand = new Random();
        //Interaction Generic
        
        
        //Interactions
        public static void FirstInteraction() //function won't return variable if void

        
        {            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nYou stare sleepily back at your mother ...");
            Console.WriteLine("\nShe looks at you expectantly...");
            Console.ReadKey();
            Combat(false, "Mom", 10, 100);
        }


        //Options
        public static void Combat(bool random, string name, int power, int health)
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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(n);
                Console.WriteLine(p+ "/" + h);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("======================================");
                Console.WriteLine("| (I)nvestigate  (C)ry     (A)dvance |");
                Console.WriteLine("| (R)eason       (B)lock             |");
                Console.WriteLine("| (E)at          (F)lee              |");
                Console.WriteLine("======================================");
                

                Console.WriteLine($"Please select an option: \n(I) to Investigate, (R) to Reason, (E) to eat,\n(C) to Cry, (A) to Advance to the next scene,\n(B) to block, (F) to flee. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Food " + Program.currentPlayer.food + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "i" || input.ToLower() == "investigate")
                {
                    //investigate the encounter
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Your " + n + " looks at you, expectantly.");
                    Console.WriteLine($"It's been hours since she picked you up from your father's and the road is still endless. \n");
                    Console.WriteLine($"She looks exhausted herself.");
                }
                else if (input.ToLower() == "c" || input.ToLower() == "cry")
                {
                    //cry try to win the enemies sympathy with your tears
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You start sniffling, you're exhausted from being on the road this long. You just wanna go home. \n");
                    Console.WriteLine($"Your " + n + "looks are you worried \n");
                    Console.WriteLine($"Heavy tears start falling loosly on your cheeks as you hiccup.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"It's okay honey we'll be home soon I promise.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You wipe your tears on your sleeve drying your face as you both continue the journey in silence.");


                }

                else if (input.ToLower() == "r" || input.ToLower() == "reason")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You tell your mom that you hope that you arrive home soon, and that your starving.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"You notice your mother's eyes grow wide as you look at the front mirror.");
                    Console.WriteLine($"You swear you hear her mumble a curse under her breath.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Hey, baby look in your travel bag I think I packed a few snacks for you.");
                    Console.ForegroundColor = ConsoleColor.White;
                    //figure out a way to have the character actually recieve the items to put in his pocket/bag
                }
                else if (input.ToLower() == "b" || input.ToLower() == "block")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You hold your hands up in front of you.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Your mom gives you a very confused look, without saying another word.");
                    Console.ForegroundColor = ConsoleColor.White;
                    //block use on an enemy that just won't let up
                }
                else if (input.ToLower() == "e" || input.ToLower() == "eat")
                {
                    if (Program.currentPlayer.food == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You scrounge desperately in your bag for something to snack on. It seems though that your mother has neglected to remember your snacks.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"You reach into you backpack and find your favorite snack in the bag. You take a bite of the mysterious treat.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"'Oh I'm glad you found your snacks honey.'");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int foodV = 5;
                        Console.WriteLine($"You ate one mysterious snack, you recieve " + foodV + " health!");
                        Program.currentPlayer.health += foodV;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.ReadKey();
                    //eat to regain health, it'll be fine monsters are polite enough to wait for the next turn
                }
                else if (input.ToLower() == "a" || input.ToLower() == "advance")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You ask your mom if your almost there.");
                    Console.WriteLine($"She smiles fondly at you.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"'Just about there sweetie, we just need to grab some gas!");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Scene1();
                    

                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    //flee fleeing is sometimes the best option when your a scared 5 yr old
                    //fleeing has a % chance of failing, or has a chance encounter of the monster pursuing (if i can figure that out)
                    //for sake of brevity it'll be a 50/50 chance of success.

                    if (rand.Next(0, 2) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"As you reach for the car's door handle you find that it doesn't pry open.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"Your mom looks at you bewildered.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Hey! What on Earth do you think your doing?!?! Put your hand down!.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        int damageV = 2;

                        Console.WriteLine("You lose " + damageV + " health due to your mother's dissapointed glare.");
                        Program.currentPlayer.health -= damageV;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"You unbuckle your seatbelt, and reach with your tiny arms over to the door handle.");
                        Console.WriteLine($"Once your hands grasp onto the handle you open the door the violent winds whipping at your hair.");
                        Console.WriteLine($"The car suddenly lurches and you find your tiny head hitting the pavement.");
                        Console.ForegroundColor = ConsoleColor.Red;
                        int damageV = 100;


                        Console.WriteLine($"In your last moments of clarity you see the old Corolla lurch to a stop on the road. Your vision starts to fade.\nBefore you worried mother could get to you you lost " + damageV + " health!");
                        Program.currentPlayer.health -= damageV;
                        Console.ForegroundColor = ConsoleColor.White;

                        //Die instantly retry from main screen
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                }
                if(Program.currentPlayer.health<=0)
                {
                    //death code
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n \nThe light leaves your eyes. As "+n+ " stands above you grief striken on her face.\n \nYou have died in the most foolish of ways.");
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                   
                    Console.WriteLine($"!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!\nGAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!!GAME=OVER!");

                    Console.ReadKey();

                    System.Environment.Exit(0);
                }
                Console.ReadKey();

            }
           
        }
    }
}
