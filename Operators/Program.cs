using System;
using System.Runtime.InteropServices.Marshalling;
namespace std
{
    class Program
    {
        static void Main(String[] args)
        {
            
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);

            // Arithmetic operators
            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x*y);
            Console.WriteLine(x/y);
            Console.WriteLine(x%y);
            Console.WriteLine(x++);
            Console.WriteLine(y--);
            // Assignment operators//
           Console.WriteLine("Assignment operators");
           Console.WriteLine(x+=3);
           Console.WriteLine(x-=4);
           Console.WriteLine(y*=4);
           Console.WriteLine(y/=4);
           Console.WriteLine(y%=4);
           Console.WriteLine(x&=3);
           Console.WriteLine(x^=3);

           //Comparison Operators//

           Console.WriteLine("Comaparision Operators");
           Console.WriteLine(x==y);
           Console.WriteLine(x!=y);
           Console.WriteLine(x<y);
           Console.WriteLine(x>y);
           Console.WriteLine(x<=y);
           Console.WriteLine(x>=y);

           Console.WriteLine("Logical Operators");
           Console.WriteLine(x<5 && x>10);
           Console.WriteLine(y<1||y>4);
           Console.WriteLine(!(x>5 &&x<10));


           

        }
    }
}
