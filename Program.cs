using System;

namespace Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Elements!");
            Random random = new Random();
            bool goAgain = true;
            string player;
            string computer;
            string answer;

            while (goAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "WATER" && player != "FIRE" && player != "EARTH")
                {
                    Console.Write("Please Enter WATER, FIRE, or EARTH: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "WATER";
                        break;
                    case 2:
                        computer = "FIRE";
                        break;
                    case 3:
                        computer = "EARTH";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "WATER":
                        if (computer == "WATER")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (computer == "EARTH")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;
                    case "FIRE":
                        if (computer == "FIRE")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (computer == "WATER")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;
                    case "EARTH":
                        if (computer == "EARTH")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else if (computer == "FIRE")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;
                }
                Console.Write("Want to Play Again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
                Console.WriteLine("GoodBye!!");

                Console.ReadKey();
            }
        }
    }
}
