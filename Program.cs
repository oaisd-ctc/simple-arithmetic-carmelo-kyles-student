using System;

public class program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Enter your first number: ");
        double number1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your second number: ");
        double number2 = double.Parse(Console.ReadLine());


        Console.WriteLine("Enter the operation you'd like to do. OPTIONS:Addition, Subtraction, Multiplication, Integer Division, Floating Point, Modulus");
        string operation = Console.ReadLine();
        operation.ToLower();
        if (operation.Equals("addition"))
        {
            Console.WriteLine(number1+number2);
        }

        if (operation.Equals("subtraction"))
        {
            Console.WriteLine(number1-number2);

        }

        if (operation.Equals("multiplication"))
        {
            Console.WriteLine(number1*number2);

        }

        if (operation.Equals("integer division"))
        {
            Console.WriteLine(number1/number2);

        }

        if (operation.Equals("floating point"))
        {
            Console.WriteLine((double)number1/number2);

        }

        if (operation.Equals("modulus"))
        {
            Console.WriteLine(number1%number2);

        }







    }
}