using System;
using System.Collections.Generic;
using System.Text;

namespace ESAExercise
{
    public static class Train
    {
        public static decimal TrainCalculation(decimal miles, decimal firstSpeed, decimal secondSpeed)
        {
            return miles / (firstSpeed + secondSpeed) * 60;
        }

        public static void TrainHelper()
        {

            //Introduce problem
            Console.WriteLine("\n\n2 trains approach each other from opposite directions, on parallel tracks." +
                              "\nThis function solves the amount of time it takes for the two trains to meet.");
            Console.Write("\nPlease enter the mileage between trains: ");
            decimal miles, firstSpeed, secondSpeed;

            //Ensure input is a number while gaining parameters
            while (!decimal.TryParse(Console.ReadLine(), out miles))
            {
                Console.Write("Please enter a valid number: ");
            }

            Console.Write("\nPlease enter the speed (in mph) for Train 1: ");
            while (!decimal.TryParse(Console.ReadLine(), out firstSpeed))
            {
                Console.Write("Please enter a valid number: ");
            }

            Console.Write("\nPlease enter the speed (in mph) for Train 2: ");
            while (!decimal.TryParse(Console.ReadLine(), out secondSpeed))
            {
                Console.Write("Please enter a valid number: ");
            }

            var calculation = TrainCalculation(miles, firstSpeed, secondSpeed);

            //Round the result to two decimal places for simplicity and readability
            Console.Write($"\n\nThe trains will meet each other in {Math.Round(calculation, 2)} minutes.");
        }
    }
}
