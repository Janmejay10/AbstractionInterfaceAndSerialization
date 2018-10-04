using System;
using System.IO;
namespace SerializationTask
{
    class T4
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("f:\\text1.txt"))
            {
                writer.WriteLine("Janmejay");
                writer.WriteLine("Singh");
            }
            Console.WriteLine("Data written successfully...");
            Console.Read();
        }
    }
}