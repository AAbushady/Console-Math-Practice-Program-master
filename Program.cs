/* A basic math question program that will ask the user a addition, subtraction, mutliplication,
 or division question based on user input. It will use 2 random number to help create the question
 that will be asked. A switch will be used to handle the numbers into the appropriate type of question,
 and each type of math will be handled by a function.*/

using System;

namespace Console_Math_Practice_Program
{
    class Program
    {
        static void Main(string[] args)
        {
        // Give the user the ability to go back to the begining.
        Start:
            // Create a random object for the numbers.
            Random random = new Random();
            // Create both random numbers between 0 and 100.
            int num1 = random.Next(0, 100);
            int num2 = random.Next(0, 100);

            Console.WriteLine("What type of math problem do you want to practice?");
            // This will bring the user back to the question if they do not answer appropriately.
            InvalidInput:
            Console.WriteLine("Addition, Subtraction, Multiplication, or Division?");
            
            // Create a string that will take the user's input and use it to work the program.
            string problemType = Console.ReadLine().ToLower();

            // Switch statement for dealing with each type of math problem.
            switch (problemType)
            {
                case "addition":
                    // Allows the user to try the same problem again.
                    TryAgainSum:
                    Console.WriteLine($"What is {num1} + {num2}?");
                    // Call the Addition function to add the 2 random numbers.
                    int sum = Addition(num1, num2);
                    // Take user input and convert it to an int.
                    int sumInput = Convert.ToInt32(Console.ReadLine());

                    // This if statement will move the user on if they got the question right or
                    // launch a nested if statment if they got it wrong.
                    if (sumInput == sum)
                    {
                        Console.WriteLine("Good Job!");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not quite...\nCare to try again?\n" +
                            "If you want a new problem press the 'n' key.");
                        // String to handle if the user wants to try the same question or not.
                        string newProblem = Console.ReadLine();
                        

                        // This is the nested if statement that will send the user to Start if they want
                        // a new question or have them try again if they would rather do that.
                        if (newProblem == "n")
                        {
                            goto Start;
                        }
                        else if (newProblem != "n")
                        {
                            goto TryAgainSum;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                case "subtraction":
                    // Allows the user to try the same problem again.
                    TryAgainDifference:
                    Console.WriteLine($"What is {num1} - {num2}?");
                    // Call the Subtraction function to subtract the 2 random numbers.
                    int difference = Subtraction(num1, num2);
                    // Take user input and convert it to an int.
                    int differenceInput = Convert.ToInt32(Console.ReadLine());

                    // This if statement will move the user on if they got the question right or
                    // launch a nested if statement if they got it wrong.
                    if (differenceInput == difference)
                    {
                        Console.WriteLine("Good Job!");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not quite...\nCare to try again?\n" +
                            "If you want a new problem press the 'n' key.");
                        // String to handle if the user wants to try the same question or not.
                        string newProblem = Console.ReadLine();

                        // This is the nested if statement that will send the user to Start if they want
                        // a new question or have them try again if they would rather do that.
                        if (newProblem == "n")
                        {
                            goto Start;
                        }
                        else if (newProblem != "n")
                        {
                            goto TryAgainDifference;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "multiplication":
                    // Allows the user to try the same problem again.
                    TryAgainProduct:
                    Console.WriteLine($"What is {num1} * {num2}?");
                    // Call the Multiplication function to multiply the 2 random numbers.
                    int product = Multiplication(num1, num2);
                    // Take user input and convert it to an int.
                    int productInput = Convert.ToInt32(Console.ReadLine());

                    // This if statement will move the user on if they got the question right or
                    // launch a nested if statement if they got it wrong.
                    if (productInput == product)
                    {
                        Console.WriteLine("Good Job!");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not quite...\nCare to try again?\n" +
                            "If you want a new problem press the 'n' key.");
                        // String to handle if the sure wants to try the same question or not.
                        string newProblem = Console.ReadLine();

                        // This is the nested if statement that will send the user to Start if they want
                        // a new question or have them try again if they would rather do that.
                        if (newProblem == "n")
                        {
                            goto Start;
                        }
                        else if (newProblem != "n")
                        {
                            goto TryAgainProduct;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "division":
                    // Allos the user to try the same problem again.
                    TryAgainQuotient:
                    Console.WriteLine($"What is {num1} / {num2}?");
                    // Call the Division method to divide the 2 random numbers.
                    double quotient = Division((double)num1, (double)num2);
                    // Take user input and convert it to a double.
                    double quotientInput = Convert.ToDouble(Console.ReadLine());

                    // This if statement will move the user on if they got the question right or
                    // launch a nested if statement if they got it wrong.
                    if (quotientInput == quotient)
                    {
                        Console.WriteLine("Good Job");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not quite...\nCare to try again?\n" +
                            "If you want a new problem press the 'n' key.");
                        // String to handle if the sure wants to try the same question or not.
                        string newProblem = Console.ReadLine();

                        // This is the nested if statement that will send the user to Start if they want
                        // a new question or have them try again if they would rather do that.
                        if (newProblem == "n")
                        {
                            goto Start;
                        }
                        else if (newProblem != "n")
                        {
                            goto TryAgainQuotient;
                        }
                        else
                        {
                            break;
                        }
                    }
                // This will handle invalid input and send the user to InvalidInput after letting them know the input was invalid.
                default:
                    Console.WriteLine("Not a valid input... Press any Key to Continue...");
                    Console.ReadKey(true);
                    goto InvalidInput;
            }

            // User will be prompted on if they want a new question. If they do send them to start.
            Console.WriteLine("Press any key for a New Question...");
            Console.ReadKey(true);
            goto Start; 
        }

        // The Addition function adds the 2 random numbers and returns the sum.
        private static int Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        // The subtraction function subtracts the 2 random numbers and returns the difference.
        private static int Subtraction(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }

        // The Multiplication function multiplies the 2 random numbers and returns the product.
        private static int Multiplication(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }

        // The Division function divides the 2 random numbers and returns the quotient.
        private static double Division(double num1, double num2)
        {
            double quotient = num1 / num2;
            return quotient;
        }
    }
}
