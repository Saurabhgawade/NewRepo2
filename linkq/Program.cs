using System.Text.Json;

namespace linkq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { name = "saurabh", gender = "male", physics = 10, maths = 20, english = 30 };

            string jsonPath = "C:\\Users\\Hp\\source\\repos\\linkq\\sampleJson.json";

            string readJson = File.ReadAllText(jsonPath);

            Person[] persons = JsonSerializer.Deserialize<Person[]>(readJson);

            var nameAgeList = persons.Select(x => new nameGender() { name=x.name,gender=x.gender});

            


            var list = persons.Where(x => x.english > 10).ToList();


            var result = persons.GroupBy(x => x.gender).ToList();

            var result1 = persons.GroupBy(x => x.gender).SelectMany(x => x);
            foreach(var person in result1)
            {
                Console.WriteLine("name arrange by gender" + person.name);
            }
          /*  foreach(var person in list)
            {
                Console.WriteLine(person.name);
            }
          */
          foreach(var group in result)
            {
                Console.WriteLine($"group is belongs to {group.Key}");
                foreach(var person in group)
                {
                    Console.WriteLine(person.name);
                }
            }
        }

        /* var arr = demoArr();

           //var list = arr.Select(x => x> 0).ToArray();

           var list = arr.Where(x => x > 0).Select(x => new { x }).ToArray();

           //int list1 = arr.OrderByDescending(x => x).ToArray().First();
           //Console.WriteLine(list1);

           int list1 = arr.Where(x => x > 10 || x>4).FirstOrDefault(0);
           Console.WriteLine(list1);

               foreach(var item in list)
           {
               Console.WriteLine(item);
           }*/
        static int[] demoArr()
        {
            int[] arr = new int[10];
            arr[0] = 2;
            arr[1] = 5;
            arr[3] = 6;
            arr[4] = 7;
            arr[5] = 4;

            return arr;

        }
    }
}
