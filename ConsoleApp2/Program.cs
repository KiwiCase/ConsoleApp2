namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 101);
            int guess = 0;
            int guesses = 0;

            Console.WriteLine("Guess a number between 1-100:");
            int.TryParse(Console.ReadLine(), out guess);
           

            if (randomNumber == guess)
            {
                Console.WriteLine("Correct! You win!");
            }

            if (rnd.Next(1) > guess)
            {
                Console.WriteLine("Too high...");
            }

            else
            { 
                Console.WriteLine("Too low...");

             
            }

        }
    }
}