using System;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            int userNum;
            //prompt for int
            Console.Write("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out userNum))
            {
                Console.WriteLine("Please enter a whole number integer");
                Continue();
            }
            else
            {
                //calc sq and cu
                Calc(userNum);
            }
        }

        static void Calc(int num)
        {
            //display formatted table
            Console.WriteLine("Number    Squared    Cubed");
            Console.WriteLine("=======   =======    =======");
            const string format = "{0, -10} {1, -10} {2, -10}";
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(string.Format(format, i, i * i, i * i * i));
            }
            //prompt to continue
            Continue();
        }

        static void Continue()
        {
            string response;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Continue? (y/n): ");
                response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    //if yes, restart at main
                    Main();
                }
                else if (response == "n" || response == "no")
                {
                    //if no, exit
                    i = 5;
                    return;
                }

                if (i <= 2 && response != "n" && response != "no" && response != "y" && response != "yes")
                {
                    //if the user enters neither, inform and repeat
                    Console.WriteLine("Sorry, I could not understand your response.");
                    Console.WriteLine("Please enter a valid response.");
                }
                else if (i == 3 && response != "n" && response != "no" && response != "y" && response != "yes")
                {
                    Console.WriteLine("Sorry, I could not understand your response.");
                    Console.WriteLine("If a vaild response is not entered on this attempt the program will end");
                }
                else if (i == 4 && response != "n" && response != "no" && response != "y" && response != "yes")
                {
                    Console.WriteLine("Sorry, I could not understand your response.");
                    Console.WriteLine("You have run out of continue attempts and the program has terminated.");
                }
            }
            return;
        }
    }
}
