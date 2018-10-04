using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SerializationTask
{
    class T2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                Id = 101,
                Name = "Jay",
                Degree = "Btech",
                Hobbies = new List<string>()
                {
                    "Bandminton",
                    "travelling",
                }

            };
            // saving data into a separate file

            string strResultJson = JsonConvert.SerializeObject(s1);
            // Console.WriteLine(strResultJson);

            File.WriteAllText(@"student.json",strResultJson);
            Console.WriteLine("stored successfully");
            Console.WriteLine("all the values are converted into JSON format");
            Console.Read();
        }
    }
}
