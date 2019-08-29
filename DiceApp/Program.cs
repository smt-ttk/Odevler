using System;
using System.Threading;
namespace DiceApp
{
    class Program
    {
        public static Thread thread1;
        public static Thread thread2;  

        static void Main(string[] args)
        {

            while (true)
            {
                thread1 = new Thread(birinci);
                thread1.Name = "Birinci Zar: ";
                thread1.Start();

                thread2 = new Thread(birinci);
                thread2.Name = "İkinci Zar: ";
                thread2.Start();

                Thread.Sleep(1000);
            }
        }

        private static void birinci(object obj)
        {
            Random random = new Random();

            int zarSonuc = random.Next(1, 7);
            Console.WriteLine(Thread.CurrentThread.Name + " " + zarSonuc);
        }

    }
}
