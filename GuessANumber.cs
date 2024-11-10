using System;

namespace GuessANumberGame
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int pcNumber = randomNum.Next(1, 151);
            int numCheck = pcNumber;


            while (true)
            {

                Console.Write("Guess a number (1-150): ");
                string input = Console.ReadLine();
                bool valid = int.TryParse(input, out numCheck);


                if (valid)
                {

                    int num = int.Parse(input);

                    if (pcNumber == num)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (pcNumber < num)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if (pcNumber > num)
                    {
                        Console.WriteLine("Too Low");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input");
                }

            }
        }
    }
}
