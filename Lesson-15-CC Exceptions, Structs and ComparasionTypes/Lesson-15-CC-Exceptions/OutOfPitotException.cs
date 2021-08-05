using System;
using System.Runtime.Serialization;

namespace Lesson_15_CC_Exceptions
{
    [Serializable]
    internal class OutOfPitotException : ApplicationException
    {
        public OutOfPitotException()
        {
        }

        public OutOfPitotException(string message) : base(message)
        {
        }

        public OutOfPitotException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfPitotException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}