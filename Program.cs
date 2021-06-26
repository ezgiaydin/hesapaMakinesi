using System;

namespace hesapmak
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double answer;
            string process;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operator(*,/,+,-)");
            process = Console.ReadLine();

            if (process == "+")
            {
                answer = num1 + num2;
                Console.WriteLine("Answer: " + answer);
            }
            if (process == "-")
            {
                answer = num1 - num2;
                Console.WriteLine("Answer:" + answer);
            }
            if (process == "*")
            {
                answer = num1 * num2;
                Console.WriteLine("Answer: " + answer);
            }
            if (process == "/")
            {
                answer = num1 / num2;
                Console.WriteLine("Answer: " + answer);
            }
            else
            {
                Console.WriteLine("Incorrect operator entry!");
            }



        }
    }
}
