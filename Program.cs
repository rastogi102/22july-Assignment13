using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //---Task 1: Hello World----
            //    Console.WriteLine("Hello World!");

            //    //---Task 2: Variables and User Input----

            //    // Ask the user for their name
            //    Console.Write("Please enter your name: ");

            //    // Read the user's input and store it in a variable
            //    string userName = Console.ReadLine();

            //    // Print the personalized greeting message
            //    Console.WriteLine("Hello, " + userName + "!");

            //    //---Task 3: Basic Arithmetic----

            //    // Ask the user for the first integer
            //    Console.Write("Enter the first integer: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    // Ask the user for the second integer
            //    Console.Write("Enter the second integer: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    // Perform the operations
            //    int addition = num1 + num2;
            //    int subtraction = num1 - num2;
            //    int multiplication = num1 * num2;

            //    // Check if the second number is not zero to avoid division by zero
            //    int division = 0;
            //    int modulus = 0;
            //    if (num2 != 0)
            //    {
            //        division = num1 / num2;
            //        modulus = num1 % num2;
            //    }

            //    // Display the results
            //    Console.WriteLine($"Addition: {addition}");
            //    Console.WriteLine($"Subtraction: {subtraction}");
            //    Console.WriteLine($"Multiplication: {multiplication}");

            //    // Handle division by zero
            //    if (num2 != 0)
            //    {
            //        Console.WriteLine($"Division: {division}");
            //        Console.WriteLine($"Modulus: {modulus}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Division: Cannot divide by zero!");
            //        Console.WriteLine("Modulus: Cannot calculate modulus with zero divisor!");
            //    }

            //    //---Task 4: Control Structures----

            //    // Ask the user to enter an integer
            //    Console.Write("Enter an integer: ");
            //    int number = int.Parse(Console.ReadLine());

            //    // Check if the number is even or odd using conditional statements
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} is an even number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is an odd number.");
            //    }

            //    //Task 5: Loops

            //    // Using a while loop to print numbers from 1 to 10
            //    int i = 1;
            //    while (i <= 10)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            //    // Using a for loop to print numbers from 1 to 10

            //    for(int x=1; x<=10; x++)
            //    {
            //        Console.WriteLine(x);
            //    }


            //    //---Task 6: Arrays----

            //    // Declare an integer array with five elements
            //    int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            //    // Calculate the sum of the elements in the array
            //    int sum = 0;
            //    foreach (int num in numbers)
            //    {
            //        sum += num;
            //    }

            //    // Calculate the average of the elements in the array
            //    double average = (double)sum / numbers.Length;

            //    // Display the sum and average on the console
            //    Console.WriteLine($"The Sum of the elements is: {sum}");
            //    Console.WriteLine($"The Average of the elements is: {average}");


            //    // Task 7: Methods

            //    // Prompt the user to enter an integer
            //    Console.Write("Enter a positive integer: ");
            //    int number1 = int.Parse(Console.ReadLine());

            //    // Call the CalculateFactorial method and display the result
            //    long factorial = CalculateFactorial(number1);
            //    Console.WriteLine($"The factorial of {number1} is: {factorial}");
            //}

            //static long CalculateFactorial(int n)
            //{
            //    // Base case: Factorial of 0 is 1
            //    if (n == 0)
            //        return 1;

            //    // Recursive case: Calculate factorial using recursion
            //    return n * CalculateFactorial(n - 1);
            //}


            //--- Task 8: Exception Handling----

            int age;

            // Prompt the user for their age and validate the input using int.TryParse()
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    // Input is a valid integer, break out of the loop
                    break;
                }
                else
                {
                    // Input is not a valid integer, display an error message
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }

            // Determine if the person is a minor, an adult, or a senior
            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
            Console.ReadLine();
        }

    }
}

