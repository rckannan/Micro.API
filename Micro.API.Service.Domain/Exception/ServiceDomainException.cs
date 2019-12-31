

namespace Micro.API.Service.Domain.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ServiceDomainException : Exception
    {
        public ServiceDomainException()
        {

        }

        public ServiceDomainException(string message):base(message)
        {

        }

        public ServiceDomainException(string message, Exception innerException) 
            : base(message, innerException)
        {

        }
    }
}
