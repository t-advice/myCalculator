using System.Diagnostics;

namespace myCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Welcome to my calculator");
                Console.ResetColor();

                Console.WriteLine("/n Enter what you want to do");
                Console.WriteLine("1. Do additions");
                Console.WriteLine("2. Do subtractions");
                Console.WriteLine("3. Do multiplications");
                Console.WriteLine("4. Do divisions");
                Console.WriteLine("5. exit the calculator");
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine();


                string? choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice)) // Check if the input is null or empty
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue; // Skip to the next iteration of the loop
                }
                switch (choice)         // represents the operation the user wants to perform 
                {
                    case "1":
                        Console.Write("Enter the first number: ");         // add
                        double a = Convert.ToDouble((Console.ReadLine()));

                        Console.Write("Enter the second number: ");
                        double b = Convert.ToDouble((Console.ReadLine()));

                        Console.WriteLine($"Result: {a + b}");
                        break;

                    case "2":
                        Console.Write("Enter the first number: ");          // substract
                        double c = Convert.ToDouble((Console.ReadLine()));

                        Console.Write("Enter the second number: ");
                        double d = Convert.ToDouble((Console.ReadLine()));

                        Console.WriteLine($"Result: {c - d}");
                        break;

                    case "3":
                        Console.Write("Enter the first number: ");           // multiply
                        double e = Convert.ToDouble((Console.ReadLine()));

                        Console.Write("Enter the second number: ");
                        double f = Convert.ToDouble((Console.ReadLine()));

                        Console.WriteLine($"Result: {e * f}");
                        break;

                    case "4":
                        Console.Write("Enter the first number: ");
                        double g = Convert.ToDouble((Console.ReadLine()));

                        Console.WriteLine("Enter the second number: ");
                        double h = Convert.ToDouble((Console.ReadLine()));

                        Console.WriteLine($"Result: {g / h}");
                        break;

                    case "5":
                        Console.WriteLine("Exiting the calculator. Goodbye!");
                        return; // Exit the program 

                    default:
                        Console.WriteLine("Incorrect input, try again");
                        break;

                }
            }
        }
    }
}// This code is a simple console-based calculator that performs basic arithmetic operations.