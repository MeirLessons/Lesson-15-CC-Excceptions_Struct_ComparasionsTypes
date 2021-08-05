using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_CC_Exceptions
{

    [Serializable]
    public class LowerThanOneException : ApplicationException
    {
        public LowerThanOneException() { }
        public LowerThanOneException(string message) : base(message) { }
        public LowerThanOneException(string message, Exception inner) : base(message, inner) { }
        protected LowerThanOneException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
