using System;
using System.Net;
namespace std;
class Program
{
    static void Main(String[] args)
    {

        //basic method return
        static void display()
        {
            Console.WriteLine("Display message");
        }
        display();

        //method without parametres

        static void greet()
        {
            Console.WriteLine("Welcome");
        }
        greet();

        //Method with parametres

        static void greet1(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        greet1("vamsi");

        //Method with returning a value

        static int Add(int a , int b)
        {
            return a+b;

        }
        int result=Add(10,20);
        Console.WriteLine(result);

        //Method OverLoading

       /* static int total(int a , int b)
        {
            return a+b;
        }
        static double total(double a,double b)
        {
            return a+b;
        } */
        
        
    }
}