using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask
{
    [Serializable]
    class T6
    {
        

        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("g:\\text2.txt"))
            {
                string json = r.ReadToEnd();
                List<SponsorInfo> items = JsonConvert.DeserializeObject<List<SponsorInfo>>(json);
            }
        }

        public class SponsorInfo
        {
            public decimal Sid { get; set; }
            public decimal Sclass { get; set; }
            public decimal Sbusno { get; set; }
            

        }

        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("f:\\text2.txt"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                List<SponsorInfo> items = JsonConvert.DeserializeObject<List<SponsorInfo>>(json);

                foreach (var item in array)
                {
                    Console.Write(item);
                }
            }
            Console.Read();

        }
    }
}