using System;
using System.Collections.Generic;
using System.Text;

namespace Aula145_ExceptionExercise.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
