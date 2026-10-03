using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gianPTmidterm
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            // loop
            for (int loopCount = 0; loopCount <= 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " +  thread.Name + " Process = " + loopCount);
                

                // deley for 0.5 seconds
                Thread.Sleep(500);
            }   
        }

        public static void Thread2()
        {
            // Loops  
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " +  thread.Name + " Process = " + loopCount);

                // deley for 1.5 seconds
                Thread.Sleep(1500);
            }
        }
    }
}