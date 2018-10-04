using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask
{
    [Serializable]

    public class secreteClass

    {

        private int myaccountnumber = 172;

        [NonSerialized()]

        private string password = "tangocharlie";



        public int MyAccNum

        {

            get

            {

                return myaccountnumber;

            }

            set

            {

                myaccountnumber = value;

            }

        }

        public string Passwd

        {

            get

            {

                return password;

            }

            set

            {

                password = value;

            }

        }

        public secreteClass()

        {



        }


    }
}
