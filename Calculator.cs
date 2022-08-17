using System;

namespace MyNameSpace
{
    class practice
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiply(*) Divide(/) Add(+) or Subtract?(-)");
            string theOperation = Console.ReadLine();

            while (theOperation != "r")
            {
                if (theOperation == "*")
                {
                    Console.WriteLine(a * b);
                    Main();
                }
                else if (theOperation == "/")
                {
                    Console.WriteLine(a / b);
                    Main();
                }
                else if (theOperation == "+")
                {
                    Console.WriteLine(a + b);
                    Main();
                }
                else if (theOperation == "-")
                {
                    Console.WriteLine(a - b);
                    Main();
                }
            }
        }
    }
}