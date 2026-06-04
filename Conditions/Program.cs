using System;
namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            if (n >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if(n >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (n >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
        }

        
       /* simple-if condtion

        if(n>15){
            Console.WriteLine("Passs")
        }

        nested-if
        bool hasTicket = true;
        if(n>18){
            if(hasTicket){
                Console.WriteLine("Entry allowed.");
            }
        }

        Ternary operator:
        string result = n>=18?"Adult":"Minor";
        Console.WriteLine(result); */


       /* Switch case:
        int day = 3;
        switch(day){
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            default:
            Console.WriteLine("Invalid day");
            break;
            }
            */
    }
}