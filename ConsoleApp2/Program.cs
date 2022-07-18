namespace HighLowGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100) + 1;
            int guess = 0;
            var count = 0;
            String response;

            while (guess != randomNumber)
            {

                Console.WriteLine("Guess a number between 1-100:");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                if (guess < randomNumber)
                {
                    Console.WriteLine($"{guess} is too low...");
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine($"{guess} is too high...");
                }

                if (guess + 5 == randomNumber || guess - 5 == randomNumber)
                {
                    Console.WriteLine("You're close!");
                }

                if (guess == randomNumber)
                {
                    Console.WriteLine("Correct! You win!");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Press Y to play again or N to quit.");
                    response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        count = 0;
                        guess = 0;
                    }
                    else
                    {
                        Console.WriteLine("OK then! Bye!");
                        guess = randomNumber;
                    }
                }

                count++;

                if (count == 10)
                {
                    Console.WriteLine("Too many guesses! Press Y to start again or N to quit.");
                    response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        count = 0;
                        guess = 0;
                    }
                    else
                    {
                        Console.WriteLine("OK then! Bye!");
                        guess = randomNumber;
                    }
                }
            }

        }

    }
}