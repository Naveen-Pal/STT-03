using System;

namespace BasicOperations
{
    class Calculator
    {   static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            Console.WriteLine($"\nAddition: {sum}");
            Console.WriteLine($"Subtraction: {difference}");
            Console.WriteLine($"Multiplication: {product}");

            if (b!= 0){
                double quotient = a / b;
                Console.WriteLine($"Division: {quotient}");
            }
            else{
       Console.WriteLine("Division: Undefined (division by zero)");
            }   
            if (sum % 2 == 0)
                Console.WriteLine($"The sum {sum} is Even.");
            else
                Console.WriteLine($"The sum {sum} is Odd.");
        }
    }
}