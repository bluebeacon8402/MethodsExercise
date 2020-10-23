using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Your name is {name}, your favorite color is {color}, your favorite animal is {animal}, your favorite band is {band}");
           

            static int Add(int x, int y)
            {
                return x + y;
            }
            int result = Add(8, 8);

            Console.WriteLine(result);

            static int Multiply(int x, int y)
            {
                return x * y;
            }
            int result2 = Multiply(9, 9);

            Console.WriteLine(result2);

            static int Substract(int x, int y)
            {
                return x - y; 
            }
            int result3 = Substract(5, 2);

            Console.WriteLine(result3);

            static int Divide(int x, int y)
            {
                return x / y;
            }
            int result4 = Divide(10, 2);

            Console.WriteLine(result4);

            static int Add1(int x, int y)
            {
                return x + y;
            }
            Console.WriteLine("Pick a random number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another random number.");
            Console.WriteLine("I will now add the two numbers together.");
            int y = Convert.ToInt32(Console.ReadLine());
            int result5 = Add1(x, y);

            Console.WriteLine(result5);
        }
    }
}
