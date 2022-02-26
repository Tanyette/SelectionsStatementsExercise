using System;

namespace SelectionsStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do
            {

                Console.WriteLine("Pick a number from 1 to 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput } is too high.");
                }
                else
                {
                    Console.WriteLine("You guessed it!!");

                }

            } while (favNumber != userInput);
            */
            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "mathmatics":
                case "math":
                    Console.WriteLine("I hate Math!!");
                    break;
                case "science":
                    Console.WriteLine("I love Science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!!");
                    break;
                case "history":
                    Console.WriteLine("History is fun.");
                    break;
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                    default:
                    Console.WriteLine("I don't know that subject.");
                    break;


            }
        }
    }
}
