using System;
using Functions;


namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Stopwatch = new Functions.Stopwatch();

            while(true) {
                Console.WriteLine("Enter a command:\nstart\nstop\nreset\n");
                string command = Console.ReadLine();
                
                
                if(command == "start"){
                    Stopwatch.Start();
                    Console.WriteLine();                
                }

                else if (command == "stop") {
                    Stopwatch.Stop();
                    Console.WriteLine();    
                }

                else if (command == "reset") {
                    Stopwatch.Reset();
                    Console.WriteLine();    
                }

                else {
                    break;
                }
            }

            

        }
    }
}
