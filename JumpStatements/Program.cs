using System;
namespace std
{
    class Program
    {
        static void Main(String[] args)
        {
            //--Jump Statements --//
            

            //----1.Break-----//
           /* for(int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            } */

            //---2.Continue----//

            /* for(int i = 0; i <= 10; i++)
            {
                if (i == 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/


            //--Go to---//
            int number = 1;

            start:

            Console.WriteLine(number);
            number++;

             if (number <= 5)
            {
            goto start;
            }



        }
    }
}