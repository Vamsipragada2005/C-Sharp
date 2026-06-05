using System;
using System.Net.Mime;
namespace std
{
    class Program
    {
        static void Main(String[] args)
        {

            //--------While Loop------//
            /*int n = 0;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }

            */


            //-----Do/While Loop-------//

            
           /* int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }while(i<=1000); */

            //----For Loop-----//
            int n  = int.Parse(Console.ReadLine()!);
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}