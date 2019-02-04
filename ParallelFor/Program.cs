using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intel Core i5-5300U CPU
            // 5th generation - Broadwell-U
            // 2 cores, 4 threads
            // MaxDegreeOfParallelism can vary from 1 to 4
            Parallel.For(0, 10000000000,
                new ParallelOptions { MaxDegreeOfParallelism = 4 },
                   (i, state) => {
                       i = i * i;
                   });
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
