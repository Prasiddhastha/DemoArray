using System;
namespace DemoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            //since we havent given value for that array default false.
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Khushbu","Prasiddha","Shrestha"};
            Console.WriteLine($"{names[0]}\n{names[1]}\n{names[2]}\n");

        }
    }
}
