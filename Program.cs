using System; 

namespace CalculatorApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation) 
            {
                Console.Clear();
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");
                
                Console.WriteLine("Type a number, and then press Enter:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Type another number, and then press Enter:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Operator Selection
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                Console.Write("Your option?");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                    default: 
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("------------------------\n");
                Console.WriteLine("Would you like to perform another calculation? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    continueCalculation = false;
                }
            }
        }
    }
}