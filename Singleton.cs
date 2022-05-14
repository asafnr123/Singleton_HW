using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    internal class Singleton
    {

        private static readonly object key = new object();
        private static Singleton instance;



        private Singleton() { }



        public static Singleton GetInstanse()
        {
            if (instance == null)
                lock (key) 
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            return instance;
        }
    }
}
