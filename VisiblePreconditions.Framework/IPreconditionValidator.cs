using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    /// <summary>
    /// Definition of the interface for classes that want to act as a precondition validator
    /// for function arguments
    /// </summary>
    /// <typeparam name="TArg">
    /// The type that this validator can act upon
    /// </typeparam>
    public interface IPreconditionValidator<in TArg>
    {
        bool IsValid(TArg value);
    }
}
