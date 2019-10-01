using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            Boolean correct = false;
            Console.WriteLine("Try guess the number between 1 and 100");
            while (!correct)
            {
                try
                {
                    int guess =Convert.ToInt32(Console.In);

                    if (guess == num)
                    {
                        Console.WriteLine("Correct! the number was " + num);
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("");
                    }

                }
                catch (Exception e)
                {

                }
            }

        }
    }
}
