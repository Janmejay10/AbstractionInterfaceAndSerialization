using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SerializationTask
{
    class T3   // now deerializing the data
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

            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("stored successfully");

            strResultJson = string.Empty;
            strResultJson = File.ReadAllText(@"student.json");
            //our result is available in a string format
            //and deserializing the string to student type
          Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(resultStudent.ToString());

            Console.Read();
        }
    }
}
