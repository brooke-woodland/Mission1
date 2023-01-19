using System;

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to roll the dice?");
            int NumDiceRoll = Convert.ToInt32(Console.ReadLine());


            int[] Rolls = new int[11];

            for (int i = 0; i < 6; i++)
            {
                Rolls[i] = 0;
            }

            for (int i = 0; i < NumDiceRoll; i++)
            {
                Random rnd = new Random();

                Rolls[rnd.Next(6) + rnd.Next(6)]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + NumDiceRoll);


            for (int i = 0; i < 11; i++)
            {
                double star = ((double)Rolls[i] / NumDiceRoll) * 100;

                Console.Write((i + 2) + ": ");

                for (int i2 = 0; i2 < star; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
