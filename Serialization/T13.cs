using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using SerializationSample;

namespace SerializationTask
{
    class T13
    {
        static void Main(string[] args)
        {
            //let's first instantiate our Sample object
            //and set its two properties
            Sample1 sample = new Sample1();
            sample.Name = "Janmejay";
            sample.Age = 23;

            //next, create an instance of an XmlSerializer
            //we will use the Type constructor for this example
            XmlSerializer serializer = new XmlSerializer(typeof(Sample1));

            //serialize the object to the Console
            serializer.Serialize(Console.Out, sample);

            Console.ReadLine();
        }
    }
}
