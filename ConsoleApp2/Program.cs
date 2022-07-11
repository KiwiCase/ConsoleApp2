namespace HighLowGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(100) + 1;
            int guess = 0;

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

            if (guess == randomNumber)
            { 
                Console.WriteLine("Correct! You win!");

            }
            
            }

        }
    }
}