using System;
using System.Runtime.Serialization;

namespace Lesson_15_CC_Exceptions
{
    [Serializable]
    internal class DishNotValidException : ApplicationException
    {
        public DishNotValidException()
        {
        }

        public DishNotValidException(string message) : base(message)
        {
        }

        public DishNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DishNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}