using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold multiple zombies
            List<Zombie> zombies = new List<Zombie>();
            // Creat a new player
            Player player = new Player(400,0);

            // Create and add multiple zombies to the list
            for (int i = 0; i < 5; i++)
            {
                // Generate random initial positions for each zombie
                int initialX = new Random().Next(0, 801);
                // Y coordinate set to 0 (zombies on top of the screen) 
                int initialY = 0; 

                // Create a new zombie with random initial position
                Zombie zombie = new Zombie(initialX, initialY);

                // Add the zombie to the list
                zombies.Add(zombie);
            }

            //Keyboard input to move player 
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    // Check which key is pressed and move the player accordingly
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            player.char_move(-1); // Move left
                            break;
                        case ConsoleKey.RightArrow:
                            player.char_move(1); // Move right
                            break;
                        default:
                            // Ignore other keys
                            break;
                    }
                }

                // Move each zombie down 
                foreach (Zombie zombie in zombies)
                {
                    zombie.zomb_move();
                    Console.WriteLine($"Zombie position: ({zombie.x}, {zombie.y})");
                }

            }

            // Print out the coordinates and speed of each zombie
            foreach (Zombie zombie in zombies)
            {
                Console.WriteLine("Zombie coordinates: (" + zombie.x + ", " + zombie.y + ")");
                Console.WriteLine("Zombie speed: " + zombie.speed);
                Console.WriteLine();
            }

            Console.WriteLine("Player coordinates : (" + player.x + ", " + player.y + ")");
            Console.WriteLine("Pkayer speed: " + player.speed);
            Console.WriteLine();

            // Delay to prevent high CPU usage
            System.Threading.Thread.Sleep(100);
        }
    }
}

