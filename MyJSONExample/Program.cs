using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJSONExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };
            WriteToAFile(movie);
            Console.WriteLine("==========");

            Movie newMovie1 = ReadFromAllFileUsingString();
            Console.WriteLine($"Movie information: name = {newMovie1.Name} Year: {newMovie1.Year}");
            Console.WriteLine("==========");

            Movie newMovie2 = ReadFromAFileDirectly();
            Console.WriteLine($"Movie information: name = {newMovie2.Name} Year: {newMovie2.Year}");
        }

        static void WriteToAFile(Movie movie)
        {
            File.WriteAllText(@"C:\temp\movie.json", JsonConvert.SerializeObject(movie));

            using (StreamWriter file = File.CreateText(@"C:\temp\movie2.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
        }

        static Movie ReadFromAllFileUsingString()
        {
            Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"C:\temp\movie.json"));
            return movie1;
        }

        static Movie ReadFromAFileDirectly()
        {
            Movie movie2 = null;
            using (StreamReader file = File.OpenText(@"C:\temp\movie2.json"))
            {
                movie2=new Movie
                {
                    Name = "Bad Boys",
                    Year = 1995
                }
            }

            return movie2;
        }
    }
}
