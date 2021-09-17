using System;
using System.Runtime.Serialization;

namespace OrganizationLibrary
{
    [Serializable]
    internal class ExPersonDoesNotExist : Exception
    {
        public String Message = "Person does not exist.";

        public ExPersonDoesNotExist()
        {
        }

        public ExPersonDoesNotExist(string message) : base(message)
        {
        }

        public ExPersonDoesNotExist(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExPersonDoesNotExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}