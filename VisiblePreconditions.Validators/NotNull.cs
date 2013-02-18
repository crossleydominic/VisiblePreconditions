using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiblePreconditions.Framework;

namespace VisiblePreconditions.Validators
{
    public class NotNull : IPreconditionValidator<object>
    {
        public bool IsValid(object value)
        {
            return value != null;
        }
    }
}
