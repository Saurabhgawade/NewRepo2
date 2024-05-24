using System.Diagnostics;
using System.Net.Security;

namespace AsyncSync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //for(int i = 0; i < 11; i++)
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //Task task1 = Task.Run(async () =>
            //{
            //    await Task.Delay(3000);
            //    Console.WriteLine("1");

            //});

            //Task task2 = Task.Run(async () =>
            //{
            //    await Task.Delay(1000);
            //    Console.WriteLine("2");

            //});

            //await Task.WhenAll(task1, task2);
            //Console.WriteLine("3");




            //Thread thread1 = new Thread(() =>
            //{
            //    hi();
            //});

            //Thread thread2 = new Thread(() =>
            //{
            //    hi();
            //});

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //Console.WriteLine("Hello");


            ////parallel for loop
            //Parallel.For(0, 10, x =>
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine(x);
            //});


            //process1();
            //process2();

            //Console.WriteLine("complete");
            //Console.Read();




            ////Asuncronous means parallel work on different core
            ////by using factory startnew we create diff core

            //  Task.Factory.StartNew(process1);
            //  Task.Factory.StartNew(process2);

            //  Console.WriteLine("complete");
            //  Console.Read();






            ////Syncronous executing step by step
            //Task.Delay(3000).Wait();
            //Console.WriteLine("heloo");
            //Task.Delay(5000).Wait();
            //Console.WriteLine("hii");
            Stopwatch time1 = Stopwatch.StartNew();
            long ans1 = 0;
            Thread thread1 = new Thread(() =>
            {
                ans1=factorial(5);
            });
            thread1.Start();
            thread1.Join();
            time1.Stop();



            long ans2 = 0;
            Stopwatch time2 = Stopwatch.StartNew();

            Thread thread2 = new Thread(() =>
            {
                ans2=factorial(6);
            });

            
            thread2.Start();

            
            thread2.Join();
            time2.Stop();
            Console.WriteLine(time2.ElapsedMilliseconds);
            Console.WriteLine(ans2);
            Console.WriteLine(time1.ElapsedMilliseconds);
            Console.WriteLine(ans1);

        }
        ////private static void process1()
        ////{
        ////    Task.Delay(5000).Wait();
        ////    Console.WriteLine("process1");

        //}
        //private static void process2()
        //{
        //   Task.Delay(2000).Wait();
        //    Console.WriteLine("process2");
        //}


        private static long factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);

        }
    }
}
