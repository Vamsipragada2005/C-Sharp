using System;
namespace std
{

    class Data
    {
        public void Vamsi()
        {
            Console.WriteLine("HI this is vamsi");
        }

        internal void srikar()
        {
            Console.WriteLine("This is srikar");
        }
        private void akhi()
        {
            Console.WriteLine("This is akhi");
        }
        protected void name()
        {
            Console.WriteLine("Cheppanu Brother");
        }

    }



    class Program
    {
        static void Main(String[] args)
        {
            Data obj = new Data();
            obj.Vamsi();
            obj.srikar();
        }
        
    }
}