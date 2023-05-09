using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class MojException : Exception //jest to klasa wyjatku ktora dziedziczy po klasie Exception ktora zawiera wszystkie informacje o wyjatku
    {
        private string errorCode;

        public string ErrorCode
        {
            get { return errorCode; }
            private set { errorCode = value; }
        }

        public MojException(string errorCode, string message) : base(message) {
            this.errorCode = errorCode;
        }
        public MojException() { }
        
    }
}
