namespace Custom_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                message(3);
            }
            catch(ExceptionCheck ex)
            {
                Console.WriteLine("custom catch"+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
        static void message(int no)
        {
           

            if (no != 2)
            {
                throw new ExceptionCheck("not equal 2");
            }

        }
    }
}
