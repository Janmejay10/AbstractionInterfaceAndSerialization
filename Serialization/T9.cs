using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask
{
    [Serializable]
    public class Sample
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