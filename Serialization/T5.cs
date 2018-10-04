using System;
using System.IO;
namespace SerializationTask
{
    class T5
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("f:\\text1.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.Read();
            }
        }
    }
}