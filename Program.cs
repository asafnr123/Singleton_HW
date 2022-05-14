using System;

namespace DP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.GetInstanse();

            Clock c = Clock.GetInstanse();

            Clock cc = Clock.GetInstanse();


            if (c == cc)
                Console.WriteLine("Nice");
            else
                Console.WriteLine("Try again");

            c.PrintCurrentTime();


            


            
    }
}
}
