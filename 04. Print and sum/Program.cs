using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartNum = int.Parse(Console.ReadLine());
            int EndNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int value = StartNum; value <= EndNum; value++)
            {
                Console.Write($"{value} ");
                sum += value;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
