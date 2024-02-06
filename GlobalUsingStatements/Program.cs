namespace GlobalUsingStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //global using System.Collections.Specialized;
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("Greg", "Programmer");
            nvc.Add("Ron", "Athlete");
            nvc.Add("Tom", "Directory");
            nvc.Add("Nard", "Plumber");
            foreach (var key in nvc.AllKeys)
            {
                Console.WriteLine($"Key:{key}, Value:{nvc[key]}");
            }

            Console.WriteLine("\n");

            //global using System.Text.Json;
            var programmers = new List<string>();
            programmers.AddRange(new string[] { "Greg", "Nelson", "Michelle" });
            var serialized = JsonSerializer.Serialize(programmers);
            var deserialized = JsonSerializer.Deserialize<List<string>>(serialized);
            foreach (var item in deserialized)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
