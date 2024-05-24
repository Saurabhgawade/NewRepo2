namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = exception();

            //try
            //{
            //    if (list.Count > 4)
            //    {
            //        Console.WriteLine("No error");
            //    }
            //    else
            //    {
            //        throw new Exception("size is small");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            foreach(var item in list)
            {
                try
                {
                    if(!(item is int))
                    {
                        throw new Exception("not integer");
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }






        }
        static List<int> exception()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            return list;
        }
















        //Queue<int> que = queue();

        //foreach(var item in que)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine(que.Dequeue());

        //Console.WriteLine(que.Contains(2));

        //Console.WriteLine(que.Peek());


        static Queue<int> queue()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);

            return que;
        }

















        //Stack<int> st = stack();

        //foreach(var item in st)
        //{
        //    Console.WriteLine(item);
        //}

        ///*Console.WriteLine(st.Peek())*/;
        ///

        //Console.WriteLine(st.Count());

        //Console.WriteLine(st.Pop());
        static Stack<int> stack()
        {
            Stack<int> st = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);

            return st;
        }












        //Dictionary<string,int>dictionary = dic();
        //dictionary.Remove("b");
        //dictionary["c"] = 4;
        //foreach (var item in dictionary)
        //{
        //    Console.WriteLine(item.Key + " " + item.Value);
        //}

        //var item= dictionary.ElementAt(1).Key;
        // Console.WriteLine(item);
        static Dictionary<string, int> dic()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("a", 1);
            dictionary.Add("b", 2);
            dictionary.Add("c", 3);

            return dictionary;
        }









        //var list = ListCollection();

        //foreach(int ele in list){
        //    Console.Write(ele + " ");
        //}

        //if (list.Count > 0)
        //{
        //    Console.WriteLine(list.Count);
        //}

        //bool isPresent = list.Contains(2);
        //Console.WriteLine(isPresent);

        //list.Remove(1);
        //foreach(var item in list)
        //{
        //    Console.WriteLine(item);

        //}

        //Console.WriteLine(list.IndexOf(2));
        static List<int> ListCollection()
        {
            List<int> list = new List<int>();
            
                list.Add(1);
                list.Add(2);

            
            
            return list;
        }
    }
}
