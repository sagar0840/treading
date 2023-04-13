using System;
using System.Threading;

namespace treading
{
    public class Tasks
    {
        public void Display1To5()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public void Display6To10()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.Name);
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }


    public class Program
    {
        private static object t3;

        static void Main(string[] args)
        {
            Tasks task1 = new Tasks();
            Thread t1 = new Thread(new ThreadStart(task1.Display1To5));
            Thread t2 = new Thread(new ThreadStart(task1.Display6To10));
            Thread t3 = new Thread(new ThreadStart(task1.Display1To5));
            t1.Name = "Display1-5";
            t2.Name = "Display6-10";
            t3.Name = "Thread 3";
            t1.Priority= ThreadPriority.Lowest;
            t1.Priority = ThreadPriority.Highest;
             t1.Join(3000);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}

