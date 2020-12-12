using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {                    
            Console.WriteLine("OLD VERSION:");
            Stopwatch Time = Stopwatch.StartNew();
            int[,,] b = new int[100, 100, 100];
            int res = 0;

            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        b[k, j, i]++;                        
                    }
                }                
            }
            Time.Stop();
            Console.WriteLine($"Execution Time : {Time.ElapsedMilliseconds} milliseconds");

            Console.WriteLine("NEW VERSION:");
            Time = Stopwatch.StartNew();
            int[,,] c = new int[100, 100, 100];            

            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        c[j, i, k]++;
                    }
                }
            }
            Time.Stop();
            Console.WriteLine($"Execution Time : {Time.ElapsedMilliseconds} milliseconds");
        }
    }
}
