using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to my calulator!**");
            Console.WriteLine("Please enter the number of the option you would like to do : \n1. Subtract\n2. Add\n3. Multiply\n4. Divide\n5. Exit");

            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Please enter the first number to subtract : \n");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number to subtract : \n");
                    int y = int.Parse(Console.ReadLine());
                    int ans = x - y;
                    Console.WriteLine($"If we subtract those two numbers, we get {ans}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Please enter the first number to add : \n");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number to add : \n");
                    int b = int.Parse(Console.ReadLine());
                    int ans2 = a + b;
                    Console.WriteLine($"If we add those two numbers we get {ans2}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Please enter the first number to multiply : \n");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number to multiply : \n");
                    int d = int.Parse(Console.ReadLine());
                    int ans3 = c * d;
                    Console.WriteLine($"If we multiply those two numbers we get {ans3}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Please enter the first number to divide : \n");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number to divide : \n");
                    int f = int.Parse(Console.ReadLine());
                    int ans4 = e / f;
                    Console.WriteLine($"If we multiply those two numbers we get {ans4}.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("See you next time!");
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
