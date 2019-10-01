using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            Boolean correct = false;
            int attempts = 20;
            Console.WriteLine("Try guess the number between 1 and 100");
            while (!correct || attempts >0)
            {
                try
                {
                    
                    int guess =Convert.ToInt32(Console.ReadLine());
                    attempts--;

                    if (guess == num)
                    {
                        Console.WriteLine("Correct! the number was " + num);
                        Console.WriteLine("You had "+ attempts + " attempts remaining");
                        correct = true;
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too low!");
                        Console.WriteLine(attempts + " attempts remaining");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine("Too high!");
                        Console.WriteLine(attempts + " attempts remaining");
                    }

                }
                catch (Exception e)
                {

                }
            }

        }
    }
}
