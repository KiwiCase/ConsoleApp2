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

                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low...", guess);
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine("Too high...", guess);
                }

                guess++;

                if (count == 5)
                {
                    Console.WriteLine("Too many guesses! Press Y to start again or N to quit.");
                    response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        count = 0;
                    }
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
                    }
                    else break;
                }
            }

            Console.WriteLine("OK then! Bye!");
        }

    }
}