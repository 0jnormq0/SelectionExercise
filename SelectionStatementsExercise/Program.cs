using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1: (if, else-if)

            Console.WriteLine("Want to play a game? Try to guess the number I'm thinking!");
            Console.WriteLine("But first let's make this easier...");
            Console.WriteLine("Give me the upper limit for the number range:");

            var userLimit = Console.ReadLine();

            var numUpperLimit = int.Parse(userLimit);

            //Creates random number within range provided by user
            var random = new Random();
            var number = random.Next(1, numUpperLimit);

            int userGuessInput;


            Console.WriteLine("Now input your guess.");

            userGuessInput = int.Parse(Console.ReadLine());

            if (userGuessInput < number)
            {
                Console.WriteLine("too low");
            }
            else if (userGuessInput > number)
            {
                Console.WriteLine("too high");
            }
            else if (userGuessInput == number)
            {
                Console.WriteLine("You got it! Niiiice.");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            //Part 2: (Switch/Case)

            Console.WriteLine("Question. What is your favorite school subject?");

            var favSubject = Console.ReadLine();    //evaluate to a string

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is my favorite subject, too!");
                    break;
                case "English":
                    Console.WriteLine("English is a fascinating subject!");
                    break;
                case "Science":
                    Console.Write("Science is totally cool.");
                    break;
                case "History":
                    Console.WriteLine("History is what makes the world go 'round.");
                    break;
                case "Health":
                    Console.WriteLine("Health seems useful and fun.");
                    break;
                default:
                    Console.WriteLine($"I've never taken {favSubject}. Sounds interesting!");
                    break;
            }


        }
    }
}
