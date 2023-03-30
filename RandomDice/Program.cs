using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de dados a lançar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            Random rnd = new Random();


            for (int i = 1; i<=n; i++)
            {
                
                
                int die = rnd.Next(1,6); 
                
                counter += die;
                Console.WriteLine($"Roll {i}: {die} ");
                

                
            }
            Console.WriteLine(counter);
        }
    }
}
