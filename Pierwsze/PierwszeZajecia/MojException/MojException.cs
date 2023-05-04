using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojException
{
    public class MojException : Exception
    {
/*        public MojException()
        {
        }

        public MojException(string message) : base(message)
        {
        }*/

        public string Dane
        {
            get; private set;
        }
        public MojException(string Dane) : base(Dane) { }
    }
}
