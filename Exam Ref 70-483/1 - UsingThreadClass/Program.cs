using System;
using System.Threading;

namespace ManageProgramFlow
{
   class Program
   {
      //Using the Thread class
      //ThreadStart: It's a delegate "void()".
      //Thread.Sleep(milliseconds): This indicates to the Thread is going to wait that time (milliseconds)
      //Thread.Sleep(0) indicates to Windows that Thread was finished, and it can switch to another process.

      static void Main(string[] args)
      {
         Thread t = new Thread(new ThreadStart(ThreadMethod));
         t.Start();         

         for (int i = 0; i < 4; i++)
         {
            Console.WriteLine("Main thread: Do some work.");
            Thread.Sleep(0);
         }

         //It's let the main Thread waiting until all threads fininish.
         t.Join();
      }

      /// <summary>
      /// Method used in the Thread process
      /// </summary>
      public static void ThreadMethod()
      {
         for (int i = 0; i < 10; i++)
         {
            Console.WriteLine("ThreadProc: {0}", i);
            Thread.Sleep(0);
         }
      }
   }
}