using System;

namespace RandomDiceGenerator
{
    class Program
    {

        public static int RollDice(int min, int max)
        {
            Random rolls = new Random();
            return rolls.Next(min, max + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the random dice generator.\n");

            bool again = true;
            while (again)
            {
                Console.WriteLine("\nPlease enter the number of sides to 1 of your die :");
                bool error = true;
                while (error)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        int sides = Convert.ToInt32(input);
                        
                        int die1 = RollDice(1, sides);
                        int die2 = RollDice(1, sides);
                        Console.WriteLine(die2);
                        Console.WriteLine(die1);

                        if (die1 == 1 && die2 == 1)
                        {
                            Console.WriteLine("\nSNAKE EYES!!");
                        }
                        else if (die1 == 6 && die2 == 6)
                        {
                            Console.WriteLine("\nBOXCARS, CRAPS!!");
                        }
                        else if ((die1 + die2) == 2)
                        {
                            Console.WriteLine("\nCRAPS!!");
                        }
                        else if ((die1 + die2) == 3)
                        {
                            Console.WriteLine("\nCRAPS!!");
                        }
                        else if ((die1 + die2) == 11)
                        {
                            Console.WriteLine("\nYO ELEVEN!!");
                        }

                        Console.WriteLine("\nWould you like to run the program again. ('Y' or 'N')\n");
                        string doAgain = Console.ReadLine();

                        while (again)
                        {
                            if (doAgain == "n" || doAgain == "N")
                            {
                                Console.WriteLine("\nThanks for playing.  Have a great day!");
                                return;
                            }
                            else if (doAgain == "y" || doAgain == "Y")
                            {
                                again = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter either 'Y' or 'N'");
                                doAgain = Console.ReadLine();
                                again = true;
                            }
                        }
                        again = true;
                        if (doAgain == "y" || doAgain == "Y")
                        {
                            
                        }

                        again = true;
                    }
                  
                    catch (FormatException)
                    {
                        Console.WriteLine("\nI'm sorry. Only numberic digits can be accepted.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("\nI'm sorry. Max amount of sides can only be 100.");
                    }
                    error = false;
                }
            }
        }
    }
}