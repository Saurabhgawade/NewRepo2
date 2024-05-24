namespace ThreadSafety
{
    internal class Program
    {
        private static Object obj = new object();
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(true);
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static async Task Main(string[] args)
        {
           // new Thread(Write).Start();
            for (int i = 0; i < 4; i++)
            {
                
                new Thread(Read).Start();
            }
            
            Console.Read();
        }
        static void Write()
        {
            manualResetEvent.Reset();

            Console.WriteLine("Hii");
            Thread.Sleep(3000);
            Console.WriteLine("Hello");
            manualResetEvent.Set();

        }
        static void Read()
        {
           // manualResetEvent.WaitOne();

            Console.WriteLine($"namaskar{Thread.CurrentThread.ManagedThreadId}");
            
            autoResetEvent.WaitOne();

            Console.WriteLine($"xmm{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine("Complted");
            autoResetEvent.Set();
            //Monitor.Enter(obj);
            //try
            //{

            //    Console.WriteLine($"Hello{Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(2000);
            //    throw new Exception();

            //    Console.WriteLine("Hi");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error");
            //}
            //finally
            //{


            //    Monitor.Exit(obj);
            //}
            
        }
    }
}
