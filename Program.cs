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
            }
        }
    }
}