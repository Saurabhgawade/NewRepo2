using System.Text.Json;

namespace linq_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = "C:\\Users\\Hp\\source\\repos\\linq_Json\\jsonDemo.json";

            string jsonString = File.ReadAllText(jsonPath);

            Person[] persons = JsonSerializer.Deserialize<Person[]>(jsonString);



            //linq whose math score greater than 80
            //var results = persons.Where(x => x.maths > 80).ToList();

            //foreach(var item in results)
            //{
            //    Console.WriteLine(item.name);
            //}





            ////select top 3 student that highest score in maths
            //var result = persons.OrderByDescending(x => x.maths).Take(3).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.name);
            //}


            ////top scorer in english
            //var result = persons.OrderByDescending(x => x.english).Take(1).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.name);
            //}



            ////Average of english marks
            //var result = persons.Average(x => x.english);
            //Console.WriteLine(result);


            //group by gender
            //var result = persons.GroupBy(x => x.gender);

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item1 in item)
            //    {
            //        Console.WriteLine(item1.name);
            //    }
            //}





        }
    }
}
