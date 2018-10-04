using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;

namespace SerializationTask
{
    
    class T8
    {
        static void Main()

        {

            try

            {



                secreteClass objSecrete = new secreteClass();

                objSecrete.MyAccNum = 123321456;



                //Soap serialization technique

                SoapFormatter formatter = new SoapFormatter();

                Stream objfilestream = new FileStream("F:\\Myserialzed.xml", FileMode.Create, FileAccess.Write, FileShare.None);



                formatter.Serialize(objfilestream, objSecrete);

                objfilestream.Close();

                //deserialization

                Stream objreadstream = new FileStream("F:\\Myserialzed.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

                secreteClass objSecrete2 = (secreteClass)formatter.Deserialize(objreadstream);



                int Myaccno = objSecrete2.MyAccNum;

                Console.WriteLine("AccNo:{0} " + Myaccno.ToString());

            }

            catch (Exception ex)

            {

            }
            Console.Read();
        }
    }
}
