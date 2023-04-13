using System;
using System.Threading;

namespace threding
{
    public class Tasks
    {
        private object _object = new object();



        public void Display1to5()
        {
            Thread thread= Thread.current Thread;

            Console.WriteLine(Thread.Name);

            Moniter.Enter(_object);
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Moniter.Enter(_object);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Tasks task1 = new Tasks();
                Thread t1 = new Thread(new ThreadStart(task1.Display1To5));
                Thread t2 = new Thread(new ThreadStart(task1.Display1To5));
                Thread t3 = new Thread(new ThreadStart(task1.Display1To5));
                t1.Name = "Display1-5";
                t2.Name = "Display6-10";
                t3.Name = "Thread 3";
                t1.Priority = ThreadPriority.Lowest;
                t2.Priority = ThreadPriority.Highest;
                t1.Start();
                t2.Start();
                t3.Start();
            }
        }
    }
}