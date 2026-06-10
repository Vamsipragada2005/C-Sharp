using System;
namespace std;
class Program
{
    static void Main(String[] args)
    {
        try
        {
            int a =10;
            int b = 0;
            int result = a/b;
            Console.WriteLine(result);
        }
        catch(DivideByZeroException)
        {
          Console.WriteLine("An error occurred");  
        }
    }
}