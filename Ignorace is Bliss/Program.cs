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
            Start();
        }



        static void Start() //happens seperate from the main string arguments; game start
        {
            Console.WriteLine($"Ignorance is Bliss");
            Console.WriteLine("Please insert a name:");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine($"You wake to the sound of rain pitter pattering on the side of the car's window." );
            Console.WriteLine($"Interstate lights flashing along the back of the car along your face, as your strapped in tightly in your carseat.");
            Console.WriteLine($"It still remains wholly dark outside. \n");
            Console.WriteLine($"Your mother notices you sleepily moving your head, making eye contact with you in the front mirror. \n");
            if(currentPlayer.name=="")
            {
                Console.WriteLine($"'Hey sweetie did you sleep well?'");
            }
            else

            Console.WriteLine($"'Hey " +currentPlayer.name + " did you sleep well?'");
            Console.ReadKey();
        }
    }
}
