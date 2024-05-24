namespace unittestpractise1
{
    public class ServiceDemo : Interfacedemo
    {
        List<int> list = new List<int>() { 1, 2, 3 };
        public int getValue(int ind)
        {
            return list[ind];
        }
    }
}
