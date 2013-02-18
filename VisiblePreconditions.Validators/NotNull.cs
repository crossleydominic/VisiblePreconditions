using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiblePreconditions.Framework;

namespace VisiblePreconditions.Validators
{
    /// <summary>
    /// Ensures that a function argument is not null
    /// </summary>
    public class NotNull : IPreconditionValidator<object>
    {
        public bool IsValid(object value)
        {
            return value != null;
        }
    }
}
