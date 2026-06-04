using System;
using System.Data;
namespace std
{
    class Program
    {
        static void Main(String[] args)
        {
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            Console.WriteLine(Math.Min(x,y));
            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Round(1.9));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Abs(-6));
            Console.WriteLine(Math.Pow(x,y));

            Random random = new Random();
            Console.WriteLine(random.Next(1,100));
            
            int[] nums = { 10, 20, 30, 40 };

            double average = nums.Average();

            Console.WriteLine(average);



        }
    }
}