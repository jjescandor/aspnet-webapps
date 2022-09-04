using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How many cents you want to convert?");
            double cents = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{cents} is equal to...");
            int gold = (int)cents / 10;
            int remainder = (int)cents % 10;
            int silver = remainder / 5;
            remainder = remainder % 5;
            Console.WriteLine($"{gold} gold coins, {silver} silver coins, and {remainder} bronze coins.");
        }
    }
}
