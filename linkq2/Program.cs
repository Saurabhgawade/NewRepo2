using System.Text.Json;

namespace linkq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = "C:\\Users\\Hp\\source\\repos\\linkq2\\jsondemo.json";

            string jsonData = File.ReadAllText(jsonPath);

            person[] persons = JsonSerializer.Deserialize<person[]>(jsonData);

            Console.WriteLine();
        }
    }
}

