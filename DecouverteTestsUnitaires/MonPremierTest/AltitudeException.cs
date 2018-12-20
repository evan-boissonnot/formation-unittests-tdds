using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierTest
{
    public class AltitudeException : Exception
    {
        public AltitudeException()
        {
        }

        public AltitudeException(string message) : base(message)
        {
        }

        public AltitudeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
