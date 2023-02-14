using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException() : this("Validation error occured")
        {

        }

        public ValidationException(Exception exception) : this(exception.Message)
        {

        }
    }
}
