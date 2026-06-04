using System;
namespace std{
    class Program{
        static void Main(String[] args){
            String s1 = Console.ReadLine()!;
            String s2 = Console.ReadLine()!;
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());
            Console.WriteLine(s1+s2);
            Console.WriteLine(string.Concat(s1,s2));
            //interpolation
            string name = $"My full name is : {s1} {s2}";
            Console.WriteLine(name);
            //access strings

            Console.WriteLine(s1[0]);
            Console.WriteLine(s2[1]);
            Console.WriteLine(s2.IndexOf('a'));
            Console.WriteLine(s2.Contains("vamsi"));
            Console.WriteLine(s1.StartsWith("pr"));
            Console.WriteLine(s2.EndsWith("si"));
            Console.WriteLine(s2.Substring(1,4));
            Console.WriteLine(s2.Replace("vamsi","Naidu"));
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s1==s2);
            Console.WriteLine(string.Equals(s1,s2,StringComparison.OrdinalIgnoreCase));






        }
    }
}