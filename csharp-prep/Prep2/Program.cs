using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try to guess the magic number.");
        int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();

        int magic_number = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic_number)
            {
                Console.WriteLine("Too High. Try again. ");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Too Low. Try again");
            }
            else
            {
                Console.WriteLine("You got it! Nice ");
            }

        }
   
    }
}

