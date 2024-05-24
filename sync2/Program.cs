using System.Diagnostics;

namespace sync2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //new Thread(Write).Start();
            for(int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }
            
            
            //Console.WriteLine("Hello, World!");
            //for(int i = 0; i < 10; i++)
            //{
            //    Task.Delay(2000).Wait();
            //    Console.WriteLine(i);

            //}
            //Console.Read();


            //    Task task1 = Task.Run(async() =>
            //    {
            //        await Task.Delay(6000);
            //        Console.WriteLine("1");
            //    });

            //    Task task2 = Task.Run(async () =>
            //    {
            //        await Task.Delay(2000);
            //        Console.WriteLine("2");
            //    });
            //   await Task.WhenAll(task1, task2);
            //    Console.WriteLine("3");
            //}

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


            //Parallel.For(0, 10, x =>
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine("1");
            //});

            //Task.Factory.StartNew(process1);
            //Task.Factory.StartNew(process2);
            //long ans = 0;
            //Stopwatch time1 = Stopwatch.StartNew();
            //Thread thread = new Thread(() =>
            //{
            //    ans=Factorial(5);

            //});
            //thread.Start();
            //thread.Join();
            //time1.Stop();

            //Console.WriteLine(ans);
            //Console.WriteLine(time1.ElapsedMilliseconds);

        }
        //static object _locker = new object();
        static Object _monitor = new object();
        public static void dowork()
        {
            try
            {
                Monitor.Enter(_monitor);
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  work start");
                throw new Exception();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Work end");
            }
            catch (Exception e)
            {

            }
            finally
            {


                Monitor.Exit(_monitor);
            }

        }
        static ManualResetEvent _event = new ManualResetEvent(false);
        public static void Write()
        {
            
            Console.WriteLine($"Writing {Thread.CurrentThread.ManagedThreadId}");
            _event.Reset();
            Console.WriteLine($"Writing completed {Thread.CurrentThread.ManagedThreadId}");
            _event.Set();
        }
        static AutoResetEvent _auto = new AutoResetEvent(true);
        static Mutex _mutex = new Mutex();
        public static void Read()
        {
            

            Console.WriteLine($"Waiting {Thread.CurrentThread.ManagedThreadId}");
            _mutex.WaitOne();

            Thread.Sleep(1000);
            Console.WriteLine($"Reading {Thread.CurrentThread.ManagedThreadId}");
            _mutex.ReleaseMutex();

        }
        public static long Factorial(long a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }
        public static void hi()
        {
            Console.WriteLine("1");
        }
        public static void process1()
        {
            Task.Delay(2000).Wait();
            Console.WriteLine("2");
        }
        public static void process2()
        {
            Task.Delay(2000).Wait();
            Console.WriteLine("3");
        }




    }
}
