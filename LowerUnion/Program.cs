using System;
using System.IO;
using System.Text;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(args);

            if (args.Length == 0)
            {
                Console.WriteLine("sem qualquer tipo de argumento!");
            } 

            for (int i = 0; i < args.Length; i++)
            {   
                args[i] = args[i].ToLower();
                
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < args.Length; i++)
            {
                if(i < args.Length - 1)
                    sb.Append(args[i]).Append("_");
                else
                    sb.Append(args[i]);
            }
            Console.WriteLine(sb);
               

            
        }
    }
}
