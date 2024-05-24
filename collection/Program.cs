using collection.Model;
using System.Text.Json;

namespace collection
{
    internal class Program
    {
        static void performoperation()
        {
            bool iseeror = true;
            if (iseeror)
            {
                throw new CustomException("error");
            }
            Console.WriteLine("Completed");
        }
        static void Main(string[] args)
        {

            try
            {
                performoperation();
            }
            catch(CustomException ex)
            {
                Console.WriteLine("custom errr" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("diff error");
            }












            //List<Student> students = new List<Student>() { new Student() { rollno=1,name="saurabh",gender="male",Marks=20},
            //new Student(){rollno=2,Marks=23,gender="fema",name="jaya" }
            // };

            //var result = students.GroupBy(x => x.gender).Select(p => new
            //{
            //    rollno = p.Key,
            //    Marks = p.Sum(z => z.Marks)
            //}).ToList();

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.rollno + "  " + item.Marks);
            //}

            //string path = "C:\\Users\\Hp\\source\\repos\\collection\\sample.json";
            //try { 

            //string readall = File.ReadAllText(path);

            //Person[] persons = JsonSerializer.Deserialize<Person[]>(readall);
            
      

            //    var result = persons.GroupBy(x => x.gender).Select(p => new
            //    {
            //        gender = p.Key,
            //        average = p.Average(s => s.chemistry)
            //    }).ToList();


            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item.gender + "   " + item.average);
            //    }
            //}
            //catch(FileNotFoundException e)
            //{
            //    Console.WriteLine($"File Not Found {e.Message}");
            //}




            //SortedList<int, int> solist = new SortedList<int, int>();




            //Queue<int> que = new Queue<int>();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Dequeue();

            //Console.WriteLine(que.Count);





            //Stack<int> st = new Stack<int>();
            //st.Push(1);
            //st.Push(2);
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Peek());
            //Console.WriteLine(st.Count);

            //Dictionary<int, int> dict = new Dictionary<int, int>();

            //dict.Add(1, 2);
            //dict.Add(2, 4);

            //dict[1] = 5;
            //dict.Remove(1);
            //Console.WriteLine(dict.ContainsKey(1));

            //foreach(var item in dict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}









            ////generic collection
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);


            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.IndexOf(2));
            //Console.WriteLine(list.Contains(3));
        }
    }
}
