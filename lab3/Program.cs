using System;
using Roman;

namespace lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ushort[] number = { 3, 459, 1002, 84, 132 };
            RomanNumber[] rn = { new RomanNumber(number[0]), new RomanNumber(number[1]),
                new RomanNumber(number[2]), new RomanNumber(number[3]), new RomanNumber(number[4]) };

            for (int i = 0; i < 5; i++)
                Console.Write($"{number[i]}\t");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                Console.Write($"{rn[i].ToString()}\t");

            Console.WriteLine($"\n\nСумма:\t {number[0]} + {number[1]} = {number[0] + number[1]}");
            Console.WriteLine($"\t {rn[0].ToString()} + {rn[1].ToString()} = {(rn[0] + rn[1]).ToString()}");

            Console.WriteLine($"\n\nРазность:\t {number[1]} - {number[0]} = {number[1] - number[0]}");
            Console.WriteLine($"\t\t {rn[1].ToString()} - {rn[0].ToString()} = {(rn[1] - rn[0]).ToString()}");

            Console.WriteLine($"\n\nУмножение:\t {number[0]} * {number[1]} = {number[0] * number[1]}");
            Console.WriteLine($"\t\t {rn[0].ToString()} * {rn[1].ToString()} = {(rn[1] * rn[0]).ToString()}");

            Console.WriteLine($"\n\nДеление:\t {number[1]} / {number[0]} = {number[1] / number[0]}");
            Console.WriteLine($"\t\t {rn[1].ToString()} / {rn[0].ToString()} = {(rn[1] / rn[0]).ToString()}");

            Console.WriteLine("\n\nОтсортированный массив:");
            Array.Sort(rn);
            Array.Sort(number);
            for (int i = 0; i < 5; i++)
                Console.Write($"{number[i]}\t");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                Console.Write($"{rn[i].ToString()}\t");
            Console.WriteLine();
        }
    }
}