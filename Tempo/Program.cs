using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);

            crono2.Start();
            Thread.Sleep(300);

            crono1.Stop();
            crono2.Stop();

           float time1sec = crono1.ElapsedMilliseconds / 100f;
           float time2sec = crono2.ElapsedMilliseconds / 100f;
           
            
           Console.WriteLine(time1sec);
           Console.WriteLine(time2sec);


        }
    }
}
