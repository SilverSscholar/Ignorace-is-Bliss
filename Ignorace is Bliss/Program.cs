using System;
using System.Collections.Generic;
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
        }



        static void Start() //happens seperate from the main string arguments; game start
        {
          
            Console.WriteLine($"Ignorance is Bliss");
            Console.WriteLine("Please insert a name:");
            Console.ForegroundColor = ConsoleColor.White;
            currentPlayer.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine($"You wake to the sound of rain pitter pattering on the side of the car's window." );
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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'Hey sweet thing, sorry I swear we're almost done.\nWhy don't you come inside the KREUGER with me? We'll grab some dinner!'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nIt wasn't like you had much of a choice, while still sleepy you nodded begrudingly.\nUnbuckling yourself from the shackles that bound you to your carseat.");
            Console.WriteLine($"Your mother reached for your hand, and you took it in stride.\nIt was too late to argue against how big you were, and you were too tired to really say anything.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"As you walked in your footie pajamas into the large KREUGER you noticed the central window lights flickering on, and off.\n Being the asute" +
                $"child that you were you very worriedly pointed it out.\nYour mother gave you a very gentle smile, and assured you that it was nighttime and the building was tired.");
            Console.WriteLine("That seemed to satisfy you for the time being.");
            Console.ReadKey();
            Console.Clear();
        }
            
    }
}
