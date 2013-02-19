using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    /// <summary>
    /// Exception that gets generated when a function argument/return value does not pass it's condition checks
    /// </summary>
    public class ConditionViolatedException : Exception
    {
        public ConditionViolatedException(Type argumentType, string argumentValue, Type validationFunctionType) :
            base(string.Format("Parameter of type '{0}' with value '{1}' failed condition check '{2}'",
                argumentType.FullName,
                argumentValue,
                validationFunctionType.FullName)) { }
    }
}
