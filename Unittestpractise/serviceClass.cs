namespace Unittestpractise
{
    public class serviceClass : Interface
    {

        List<int> list = new List<int>() { 1,2,3,4};
        
        public int demo(int b)
        {
            return list[b];
        }

        public int getValue(int b)
        {
            int a = demo(b);
            return a;
        }
    }
}
