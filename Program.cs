using System;

namespace ESAExercise
{
    class Program
    {
        static void Main()
        {
            Console.Write("1. Directory File Finder \n2. Train Speed Calculation\n\nPlease enter a selection: ");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                DirectoryPrint.PrintHelper();
            }

            if (selection == "2")
            {
                Train.TrainHelper();
            }

            else
            {
                Console.Write("Sorry, that is not a valid option.");
            }

            


        }
    }
}
