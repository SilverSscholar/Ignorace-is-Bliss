using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignorace_is_Bliss
{
    class Program
    {
        public static Player currentPlayer = new Player();


        static void Main(string[] args)

        {
            //Set the Background Color and Foreground Color
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Start();
            Interactions.FirstInteraction();
            Scene1();
            Scene2();
            RecieveGroceryList();
            
        }



        static void Start() //happens seperate from the main string arguments; game start
        {

            Console.WriteLine($"Ignorance is Bliss");
            Console.WriteLine("Please insert a name:");
            Console.ForegroundColor = ConsoleColor.White;
            currentPlayer.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine($"You wake to the sound of rain pitter pattering on the side of the car's window.");
            Console.WriteLine($"Interstate lights flashing along the back of the car along your face, as your strapped in tightly in your carseat.");
            Console.WriteLine($"It still remains wholly dark outside. \n");
            Console.WriteLine($"Your mother notices you sleepily moving your head, making eye contact with you in the front mirror. \n");
            if (currentPlayer.name == "")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Hey sweetie did you sleep well?");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"'Hey " + currentPlayer.name + " did you sleep well?'\n");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Scene1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The road's continue on seemingly endless. As you stare out the window watching the exit signs rush by, when eventually you see your mom's exit. ");
            Console.WriteLine("Letting out a sigh of relief, as the steady noise of the car's right blink blips on.\nThe KREUGER sign illuminating the last step before the end of your journey.");
            Console.WriteLine("\nGas pumps litter the front of the grocer, and your mom leaves her vehicle, to pump up the gas.");
            Console.ReadKey();
            Console.Clear();
            //set dialogue 1
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'Hey sweet thing, sorry I swear we're almost done.\nWhy don't you come inside the KREUGER with me? We'll grab some dinner!'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nIt wasn't like you had much of a choice, while still sleepy you nodded begrudingly.\nUnbuckling yourself from the shackles that bound you to your carseat.");
            Console.WriteLine($"Your mother reached for your hand, and you took it in stride.\nIt was too late to argue against how big you were, and you were too tired to really say anything.");
            Console.ReadKey();
            Console.Clear();
            //set dialogue 2
            Console.WriteLine($"As you walked your footie pajams squelched in the rain water.\n You walked uncomfortably into the large KREUGER you noticed the central window lights flickering on, and off.\n Being the asute" +
                $"child that you were you very worriedly pointed it out.\nYour mother gave you a very gentle smile, and assured you that it was nighttime and the building was tired.");
            Console.WriteLine("That seemed to satisfy you for the time being.");
            Console.ReadKey();
            Console.Clear();
            //set dialogue 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(".Hey! Nicole is that you!?'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nYou didn't know who this 'Nicole' was, but your mom looked up and smiled at the man running the register.");
            Console.WriteLine($"He was a fairly imposing figure, an older man with gray whiskers on his face, and a very wrinkly forehead.\nYou didn't recongnize him.");
            Console.ReadKey();
            Console.Clear();

            if (currentPlayer.name == "")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Well I'll be, is this the same kiddo you had with-");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n'Shhhhh we don't talk about him.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nYou asked your mom who you don't talk about.\nShe smiled and gently ruffled your hair telling you not to worry about it.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Well I'll be damned! Is that litte " + currentPlayer.name + "! Oh lawdy you've gotten so big!\nCan you give Owen a highfive?");

                Console.WriteLine("Will you give uncle Own a highfive? (Y)es/(N)o");
                string highFive = Console.ReadLine();
                if (highFive.ToLower() == "y" || highFive.ToLower() == "yes")
                {
                    Console.WriteLine("You gave Uncle Owen a highfive! He seemed absolutely delighted!");
                    Console.ReadKey();
                }
                else if (highFive.ToLower() == "n" || highFive.ToLower() == "no")
                {
                    Console.WriteLine("You refused to give Uncle Owen a highfive, he seemed sad. How dare you, you monster.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You stared at Uncle Owen with a blank face.\nYour mother assures him that honestly you're just wore out.\nHe seemed understanding.");
                   
                }
                   
            }
            Console.ReadKey();
            Console.Clear();
            Scene2();
        }
        public static void Scene2()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Owen looked at you both with intrigue.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'So what are y'all planning on getting tonight?'");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'Oh just some food before we head home.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'Oh! Well it's been a while since we caught up!\n Why don't you let the little kiddo get the groceries for you!'");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'I.. dunno about that they're still a little young...'");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'They'll be fine won't you" + currentPlayer.name + "!'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Before you had a chance to nod yes or no, uncle Owen was already starting to write down a list for you.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'This is the number of every aisle, and what's in each aisle kid.\nI know you got a smart head, you can read. Just look at this.'");
            Console.ReadKey();
            Console.Clear();
            RecieveGroceryList();
        }

        public static void RecieveGroceryList()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string filePath = @"C:\Users\Trinity\Desktop\GroceryList.txt";

            //string[] lines = File.ReadAllLines(filePath);
             List<string> lines = new List<string>();
             lines = File.ReadAllLines(filePath).ToList();
             foreach (String line in lines)
             {
                 Console.WriteLine(line);
             }
             Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
        }
           
    }
}

