using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleClock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timespan will set 5-seconds
            TimeSpan duration = TimeSpan.FromSeconds(5);                        

            //distinctValues will hold the number of result sets from call to DateTime.UtcNow
            var distinctValues = new HashSet<DateTime>();


            //Stopwatch to run for duration and collect distinctValues
            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.Elapsed < duration)
            {
                distinctValues.Add(DateTime.UtcNow);
            }

            //Display count and accuracy by dividing 5-seconds by count
            Console.WriteLine("Sample Count: " + distinctValues.Count);
            Console.WriteLine($"Accuracy: {stopWatch.Elapsed.TotalMilliseconds / distinctValues.Count:0.000000} ms");
            
        }
    }
}
