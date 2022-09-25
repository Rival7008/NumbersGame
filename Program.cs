using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anton Johansson SUT22
            //Prints out as text
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            NumbersGame();

        }
        static void NumbersGame()
        {
            //Random number generator that chooses a random number between 1 and 20
            Random random = new Random();
            int number = random.Next(1, 20);

            //for loop that gives the user 5 guesses 
            for (int Guesses = 0; Guesses < 5; Guesses++)
            {
                //takes the users input from the console and puts it in the int Guess
                int Guess = Convert.ToInt32(Console.ReadLine());

                //if the guess is lower than the number it prints out the console.writeline
                if (Guess < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                //if the guess is higher than the number it prints out the console.writeline
                if (Guess > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt");
                }
                //if the guess is the same as the number it prints out the console.writeline
                if (Guess == number)
                {
                    Console.WriteLine("Woho! Du gjorde det!");

                    //breaks the loop when the guess is the same as the number
                    break;
                }
                //If the user has guessed 5 times it prints out the console.writeline and ends the loop
                if (Guesses == 4)
                {
                    Console.WriteLine("Tyvärr du kunde inte gissa rätt på fem försök!");
                }
            }
        }
    }
}