using System;

using LearnCoolSharp.CH07;

namespace LearnCoolSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person me = new Person();
            me.name = "HARIRAK";
            me.surname = "SRITHAM";
            me.age = 41;
            me.Talk("oh");
            Console.WriteLine($"{me.age}");

            
            
            
        }
    }
}
