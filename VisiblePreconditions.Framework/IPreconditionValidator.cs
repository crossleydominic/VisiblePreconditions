using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    public interface IPreconditionValidator<in TArg>
    {
        bool IsValid(TArg value);
    }
}
