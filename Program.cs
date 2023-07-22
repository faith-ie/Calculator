using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main() => new Program().Result();

        private int num1, num2;

        private async void Result()
        {
            Console.WriteLine("***Welcome to my calculator!***");
            Console.WriteLine($"Please enter the number of the operation you would like to do: \n{Operation.Add}\n{Operation.Subtract}\n{Operation.Multiply}\n{Operation.Divide}");
            int result = 0;
            if (Enum.TryParse<Operation>(Console.ReadLine(), out var op))
            {
                switch (op)
                {
                    case Operation.Add:
                        Console.WriteLine($"Insert two numbers to {op} now.");
                        int.TryParse(Console.ReadLine(), out num1);
                        int.TryParse(Console.ReadLine(), out num2);
                        result = num1 + num2;
                        break;

                    case Operation.Subtract:
                        Console.WriteLine($"Insert two numbers to {op} now.");
                        int.TryParse(Console.ReadLine(), out num1);
                        int.TryParse(Console.ReadLine(), out num2);
                        result = num1 - num2;
                        break;

                    case Operation.Multiply:
                        Console.WriteLine($"Insert two numbers to {op} now.");
                        int.TryParse(Console.ReadLine(), out num1);
                        int.TryParse(Console.ReadLine(), out num2);
                        result = num1 * num2;
                        break;

                    case Operation.Divide:
                        Console.WriteLine($"Insert two numbers to {op} now.");
                        int.TryParse(Console.ReadLine(), out num1);
                        int.TryParse(Console.ReadLine(), out num2);
                        result = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        break;
                }
            }
            await Console.Out.WriteLineAsync($"If we {op} these two numbers, we get {result}");
            await Console.Out.WriteLineAsync("Press any key to exit.");
            Console.ReadKey();
        }

        private enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        };
    }
}