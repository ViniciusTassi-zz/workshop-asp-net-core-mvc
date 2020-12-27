using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class NotFindExceptions : Exception
    {
        public NotFindExceptions()
        {
        }

        public NotFindExceptions(string message) : base(message)
        {
        }

        public NotFindExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFindExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}