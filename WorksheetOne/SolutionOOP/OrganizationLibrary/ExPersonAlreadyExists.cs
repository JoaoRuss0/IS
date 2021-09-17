using System;
using System.Runtime.Serialization;

namespace OrganizationLibrary
{
    [Serializable]
    internal class ExPersonAlreadyExists : Exception
    {
        public String Message = "Person already exists.";
        
        public ExPersonAlreadyExists()
        {
        }

        public ExPersonAlreadyExists(string message) : base(message)
        {
        }

        public ExPersonAlreadyExists(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExPersonAlreadyExists(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}