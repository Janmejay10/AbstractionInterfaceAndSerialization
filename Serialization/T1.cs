using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationTask
{
       class T1
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
            // now to convert student object to JSON data

            string strResultJson = JsonConvert.SerializeObject(s1);
            Console.WriteLine(strResultJson);
            Console.WriteLine("all the values are converted into JSO format");
            Console.Read();
        }
    }
}
