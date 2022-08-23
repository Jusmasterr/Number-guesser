namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int Number = rd.Next(1, 100);
            int Guesses = 0;
            Console.WriteLine("Guess the Number between 1 and 100:");
            bool Guessing = true;
            while (true)
            {
                int guessed_n = Convert.ToInt32(Console.ReadLine());
                if (guessed_n < 1 || guessed_n > 100)
                {
                    Console.WriteLine("Please enter a Number between 1 and 100");
                }
                else
                {
                    if (Number == guessed_n)
                    {
                        Guesses++;
                        Console.WriteLine("Great you guessed the right Number after " + Guesses + " attempts");
                        Guessing = false;
                    }
                    else
                    {
                        Guesses++;
                        if (Number > guessed_n)
                        {
                            Console.WriteLine("The number is bigger");
                        }
                        else
                        {
                            Console.WriteLine("The Number is smaller");
                        }
                    }
                }
            }
        }
    }
}