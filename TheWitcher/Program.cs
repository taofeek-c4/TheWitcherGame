using System;

namespace TheWitcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            double Userinput = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             THE WITCHER");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("\nLet the witch know your name:");
            Name = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Input a valid UserName");
            }

            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Muahaahahahahahahahahhahahahahaha!!!!!!");
                Console.WriteLine($"So....{Name} Let's play my little game");
                Console.WriteLine("If you guess the number I chose, you win");
                Console.WriteLine("---------------------------------------");

                Random random = new Random();
                int number = random.Next(1, 11);

                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine($"{Name}, pick a number between 1 and 10: ");

                    if (double.TryParse(Console.ReadLine(), out Userinput))
                    {
                        if (Userinput >= 1 && Userinput <= 10)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter a number between 1 and 10.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input......input a Number.");
                    }
                }

                Console.WriteLine($"The witch chose: {number}");

                if (number != Userinput)
                {
                    Console.WriteLine("Muhahahahahahahhahahahahahhaha!!!!!!!!!!!!!");
                    Console.WriteLine("Do you actually think you are going to win against the witch?");
                }
                else
                {
                    Console.WriteLine("Arghhhhh!!!! You won this time.");
                }

                Console.WriteLine("\nDo you want to play again?");
                Console.WriteLine("If yes, press Y. Press any other key to exit.");
            }
            while (Console.ReadLine()?.ToUpper() == "Y");

            Console.WriteLine("The witch will still be here waiting.............");
            Console.WriteLine("Muahaahahahahahahahahhahahahahaha!!!!!!!!!!!!!!!!!");
        }
    }
}
