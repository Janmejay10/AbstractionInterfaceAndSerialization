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
    class T11
    {
        static void Main(string[] args)
        {
            //create a FileStream to open the .dat file
            FileStream fileStream = new FileStream(@"f:\\MySoapFile.dat", FileMode.Open);

            //create a SoapFormatter to deserialize the object
            SoapFormatter formatter = new SoapFormatter();

            //serialize the object to the .dat file
            Sample deserializedSample = (Sample)formatter.Deserialize(fileStream);

            //show the object properties
            Console.WriteLine("The deserialized object:");
            Console.WriteLine(String.Format("Name: {0}", deserializedSample.Name));
            Console.WriteLine(String.Format("Value: {0}", deserializedSample.Age.ToString()));

            Console.Read();
        }
    }
}
