using System.Collections;

namespace Non_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        







        //SortedList list = sort();

        //foreach(DictionaryEntry entry in list)
        //{
        //    Console.WriteLine(entry.Key);
        //}
        static SortedList sort()
        {
            SortedList list = new SortedList();

            list.Add(1, "a");
            list.Add(4, 2);
            list.Add(3, "c");

            return list;
        }












        //Hashtable ht = hash();

        ////foreach(DictionaryEntry entry in ht)
        ////{
        ////    Console.WriteLine(entry.Key + " " + entry.Value);
        ////}

        //ht[1] = "b";

        //Console.WriteLine(ht[1]);
        static Hashtable hash()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "a");
            ht.Add("c", 4);

            return ht;
        }






















        //ArrayList arr = arraylist();



        //arr.Remove(true);
        //arr.RemoveAt(1);
        //int cnt = arr.Count;
        //Console.WriteLine(cnt);

        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);



        //}

        //try
        //{
        //    if (arr.Count < 5)
        //    {
        //        throw new Exception("size is small");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Ok");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        static ArrayList arraylist()
        {
            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add("a");
            arr.Add(true);

            return arr;

        }
    }
}
