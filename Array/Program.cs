using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace std
{
    class Program
    {
        static void Main(String[] args)
        {
            /* int[] nums = {10,20,30,40,50};
            int sum=0;
            int product = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                sum+=nums[i];
                product*=nums[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(product); */
            

           /* int n = int.Parse(Console.ReadLine()!);
            int [] nums= new int[n];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i]=int.Parse(Console.ReadLine()!);
            }

            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");

            } */

            int n = int.Parse(Console.ReadLine()!);
            int [] nums = new int[n];
            for(int i = 0; i < n; i++)
            {
                nums[i]=int.Parse(Console.ReadLine()!);

            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine("");
            Array.Sort(nums);
            for(int i = 0; i < n; i++)
            {
                Console.Write(nums[i]+" ");
            }
           

        }
    }
}