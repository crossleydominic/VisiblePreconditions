using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    public class PreconditionViolatedException : Exception
    {
        public PreconditionViolatedException(Type argumentType, string argumentValue, Type validationFunctionType) :
            base(string.Format("Parameter of type '{0}' with value '{1}' failed precondition check '{2}'",
                argumentType.FullName,
                argumentValue,
                validationFunctionType.FullName)) { }
    }
}
