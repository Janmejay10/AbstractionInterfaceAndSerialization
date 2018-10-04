using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationSample
{
    [Serializable]
    public class Sample1
    {
        public string Name
        {
            get;
            set;
        }

        public Int32 Age
        {
            get;
            set;
        }
    }

    
}