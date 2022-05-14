using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    
    internal class Clock
    {
        private static Clock instanse;
        private static readonly object key = new object();

        public Clock() { }

        public static Clock GetInstanse()
        {
            if (instanse == null)
            {
                lock (key)
                {
                    if (instanse == null)
                        instanse = new Clock();
                }
            }
            return instanse;
        }

        public void PrintCurrentTime()
        {
            Console.WriteLine($"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}");
        }
    }
    
}

