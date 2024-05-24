using Polly;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ThreadTask
{
    internal class Program
    {




        static AutoResetEvent autoResetEvent = new AutoResetEvent(true);
        static public async Task Main(string[] args)
        {





            //var policy = Policy.Handle<Exception>()
            //           .Retry(3, (exception, retryCount) =>
            //           {
            //               Console.WriteLine($"exception occurs{exception.Message}");
            //           });


            //policy.Execute(() =>
            //{
            //    Console.WriteLine("operation");
            //    throw new Exception("excepton occurs");
            //});


            var policy = Policy.Handle<Exception>()
                .WaitAndRetry(new[]
                {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(2),
                    TimeSpan.FromSeconds(3)
                }, (exception, timeCount, retryCount) =>
                {
                    Console.WriteLine(exception.Message);
                });

            policy.Execute(() =>
            {
                Console.WriteLine("operation");
                throw new Exception("exception occured");
            });
            










            //for(int i = 0; i < 5; i++)
            //{
            //    new Thread(Write).Start();
            //}
            //Thread.Sleep(10000);
            //autoResetEvent.Set();
            //Console.ReadKey();
        }






        static void Write()
        {
            autoResetEvent.WaitOne();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "writing");
            Thread.Sleep(2000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "writing completed");
            autoResetEvent.Set();
        }
        //static void Read()
        //{
            
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Waiting");
        //    manual.WaitOne();
        //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "reading completed");
        //}
        //static Object _locker = new Object();
        //static async Task Main(string[] args)
        //{


        //    for (int i = 0; i < 5; i++)
        //    {
        //        new Thread(doWork).Start();

        //    }
        //}
        //static void doWork()
        //{
        //    try
        //    {
        //        Monitor.Enter(_locker);
        //        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Starting");
        //        Thread.Sleep(2000);
        //        throw new Exception("");
        //        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Ending");
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        Monitor.Exit(_locker);
        //    }
            
        //}

           



















            //for(int i = 0; i < 5; i++)
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine(i);
            //}

            //Task task1 = Task.Run(async () =>
            //{
            //    for(int i = 0; i < 5; i++)
            //    {
            //        await Task.Delay(1000);
            //        Console.WriteLine(i);
            //    }
            //});

            //Task task2 = Task.Run(async () =>
            //{
            //    for (int i = 5; i < 10; i++)
            //    {
            //        await Task.Delay(1000);
            //        Console.WriteLine(i);
            //    }
            //});
            //await Task.WhenAll(task1, task2);
            //Console.WriteLine("Finish");









            //Thread thread1 = new Thread(() =>
            //{
            //    hi();
            //});

            //Thread thread2 = new Thread(() =>
            //{
            //    oof();
            //});

            //thread1.Start();
            //thread1.Join();

            //thread2.Start();
            //thread2.Join();

            //static void hi()
            //{
            //    Console.WriteLine("Hello");
            //}
            //static void oof()
            //{
            //    Console.WriteLine("hii");
            //}

            //Parallel.For(0, 10, async x =>
            //{

            //    Console.WriteLine(x);
            //});
            //    Stopwatch time1 = Stopwatch.StartNew();
            //    int ans = 0;
            //    int ans1 = 0;

            //    Thread thread1 = new Thread(() =>
            //    {
            //        ans = factorial(5);
            //    });
            //    thread1.Start();
            //    thread1.Join();
            //    time1.Stop();

            //    Console.WriteLine(ans);
            //    Console.WriteLine(time1.ElapsedMilliseconds);


            //    Stopwatch time2 = Stopwatch.StartNew();

            //    Thread thread2 = new Thread(() =>
            //    {
            //        ans1 = factorial(6);
            //    });
            //    thread2.Start();
            //    thread2.Join();
            //    time2.Stop();


            //    Console.WriteLine(ans1);
            //    Console.WriteLine(time2.ElapsedMilliseconds);


            //    static int factorial(int n)
            //    {
            //        if (n ==0)
            //        {
            //            return 1;
            //        }
            //        return n * factorial(n - 1);
            //    }




            //}
        
    }
}
