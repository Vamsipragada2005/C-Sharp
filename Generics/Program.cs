using System;
namespace std
{

    //Generic class //
    /* class Box<T>
    {
        public T? Value;
        public void Display()
        {
            Console.WriteLine(Value);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Box<int> intBox = new Box<int>();
            intBox.Value = 100;
            intBox.Display();

            Box<string> stringBox = new Box<string>();
            stringBox.Value ="vamsi";
            stringBox.Display();
        }
    }
    */

    //Generic Method//

    class Program
    {
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main()
        {
            Print<int>(100);
            Print<string>("C#");
            Print<double>(25.5);
        }
    }
}