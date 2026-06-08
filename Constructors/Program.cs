using System;
using System.Runtime.InteropServices;

namespace std
{

    //Default Constructors
   /*  class Student
    {
        public Student()
        {
            Console.WriteLine("Constructor called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); 
        }
    }
    */

    //  Constructor initializing fields

    /*class Student
    {
        string name;
        public Student()
        {
            name = "vamsi";
        }
        public void display()
        {
            Console.WriteLine(name);
        }
    
    static void Main(String[] args)
        {
            Student s = new Student();
            s.display();
        }

    } */


    //Paramaterized Contructor
    // class Student
    // {
    //     string name;
    //     public Student(string studentName)
    //     {
    //         name = studentName;
    //     }
    //     public void display()
    //     {
    //         Console.WriteLine(name);
    //     }
    //     static void Main(String[] args)
    //     {
    //         Student s = new Student("Vamsi");
    //         s.display();
    //     }
    // }

      //Constructor Overloading

      class Student
    {
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        public Student(string name)
        {
            Console.WriteLine($"name:{name}");
        }
        static void Main(String[] args)
        {
            Student s1 = new Student();
            Student s2= new Student("vamsi");
        }
    }
    }