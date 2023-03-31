using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(args); 

            for (int i = 0; i < args.Length; i++)
            {   
                args[i] = args[i].ToLower();
                Console.WriteLine(args[i]);
            }

               

            
        }
    }
}
