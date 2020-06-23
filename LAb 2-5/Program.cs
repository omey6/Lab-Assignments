using System;

namespace LAb_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Enter a Value of First number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Value of Second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            System.Console.WriteLine("Hello");
            System.Console.WriteLine("Umer!");

            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int results = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);


            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);


        }
    }
}
