using System;

namespace Functions
{
    public class Stopwatch
    {
        public bool run;
        public TimeSpan time { get; set; }
        public DateTime startTime { get; set; }
        public void Start()
        {
            if (run == true)
            {
                throw new NotSupportedException("Stopwatch Already Started Exception");

            }

            else
            {
                Console.WriteLine("Stopwatch Started");
                startTime = System.DateTime.Now - time;
                run = true;
            }




        }

        public void Stop()
        {
            if (run == false)
            {
                Console.WriteLine("Stopwatch not running");

            }

            else
            {
                Console.WriteLine("Stopwatch Stopped");
                time = System.DateTime.Now - startTime;
                run = false;
                Console.WriteLine("Time elapsed: " + time);
            }


        }


        public void Reset()
        {
            Console.WriteLine("Stopwatch Reset");
            time = TimeSpan.Zero;
            startTime = System.DateTime.Now;
        }
    }

}