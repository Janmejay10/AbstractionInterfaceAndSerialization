using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask
{
    class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }

        // in order to print the content of variable 
        // we will override ToString

        public override string ToString()
        {
            return string.Format("student info:\n\tId:{0}, \n\tName:{1}, \n\tDegree:{2}\n\t" +
                                  "Hobbies: {3}", Id, Name, Degree, string.Join(",", Hobbies.ToArray()));
        }
    }
}
