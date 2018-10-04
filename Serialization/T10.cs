using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationTask

{
    class T10                            //"SOAP SERIALIZATION"
    {
        static void Main(string[] args)
        {
            //create an instance of our Sample class
            //which we will serialize below
            Sample sample = new Sample();  // took from T9.cs
            sample.Name = "Janmejay";
            sample.Age = 23;

            //create a FileStream to accept the output
            FileStream fileStream = new FileStream(@"f:\\MySoapFile.dat", FileMode.Create);

            //create a SoapFormatter to serialize the object
            SoapFormatter formatter = new SoapFormatter();

            //serialize the object to the .dat file
            formatter.Serialize(fileStream, sample);
            Console.WriteLine("serialized successfully");
            Console.Read();
        }
    }
}