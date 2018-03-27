using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList messages = new ArrayList(args.Length / 2);
            ArrayList keywords = new ArrayList(args.Length / 2);
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                    keywords.Add(new StringBuilder(args[i].ToLower()));
                else
                    messages.Add(new StringBuilder(args[i].ToLower()));
            }
            foreach(String obj in keywords)
            {
                
            }
        }
    }
}
