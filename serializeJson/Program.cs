using System.Linq;
using System.Text.Json;

namespace serializeJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonpath = "C:\\Users\\Hp\\source\\repos\\serializeJson\\JsonFile\\demo.json";
            string jsonstring = File.ReadAllText(jsonpath);

            Student[] students = JsonSerializer.Deserialize<Student[]>(jsonstring);

            var result = students.Where(x => x.english > 40).ToList();

            foreach(var student in result)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
