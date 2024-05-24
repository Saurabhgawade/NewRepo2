using System.Text.Json;

namespace linkqdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = "C:\\Users\\Hp\\source\\repos\\linkqdemo\\jsonDemo.json";
            string dataRead = File.ReadAllText(jsonPath);

            Person[] persons = JsonSerializer.Deserialize<Person[]>(dataRead);



            /*var result = persons.OrderBy(x => x.physics).Take(3).ToList();
            foreach(var per in result)
            {
                Console.WriteLine(per.name);
            }

            var result1 = persons.OrderBy(x => x.maths).First();
            Console.WriteLine(result1.name);

            var result2 = persons.Average(x => x.english);
            Console.WriteLine(result2);
            */

            var result = persons.GroupBy(x => x.gender).ToList();
            foreach(var group in result)
            {
                Console.WriteLine($"group of{group.Key}");
                foreach(var person in group)
                {
                    Console.WriteLine(person.name);
                }
            }



        }
    }
}
