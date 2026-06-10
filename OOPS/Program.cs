using System;
namespace std;

              //Encapsulation//
class BankAccount
{
    public double balance;
    public void Deposit(double amount)
    {
        balance+=amount;
    }
    public double GetBalance()
    {
        return balance;
    }


    //Abstraction//

    /* abstract class Animal
    {
        public abstract void Sound();
    }

    class Dog : Animal
    {
        public override void Sound()
        {
          Console.WriteLine("Bark");
        }
    } */


    //Inheritence//

    class Animal
    {
      public void Eat()
        {
            Console.WriteLine("Eating..");
        }  
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking...");
            }
        }



        //Polymorphism//

        class Calculator
        {
            public int Add(int a,int b)
            {
                return a + b;
            }
            public double Add(double a , double b)
            {
                return a+b;
            }
        }

    

static void Main(String[] args)
    {
        BankAccount account = new BankAccount();
        account.Deposit(5000);
        Console.WriteLine(account.GetBalance());

        Dog dog = new Dog();
        // dog.Sound();
        dog.Eat();
        dog.Bark();

        Calculator calc = new Calculator();
        Console.WriteLine("Int Add: " + calc.Add(5, 10));
        Console.WriteLine("Double Add: " + calc.Add(5.5, 10.2));


    }
    }
}