namespace HighLowGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool playAgain = true;
            int randomNumber = rnd.Next(100) + 1;
            int guess = 0;
            var count = 0;
            String response;

            while (playAgain)
            {
                guess = 0;
                count = 0;
                response = "";
                randomNumber = rnd.Next(100) + 1;
 

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
            
                count++;
            
                if (count == 5)
                    {
                    Console.WriteLine("Too many guesses! Press Y to start again or N to quit.");
                    response = Console.ReadLine().ToUpper();

                        while (response.Any(x => !char.IsLetter(x)));
                        {
                            Console.WriteLine("Invalid input. Please press Y or N.");
                        }

                        if (response == "Y")
                            {
                            playAgain = true;
                            }
                        if (response == "N")
                            {
                            playAgain = false;
                            break;
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
                            playAgain = true;
                            }
                        if (response == "N")
                            {
                            playAgain = false;
                            }   
                    }

                }

            }
            Console.WriteLine("OK then! Bye!");
        }
    }
}