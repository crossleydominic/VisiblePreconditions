using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiblePreconditions.Framework;

namespace VisiblePreconditions.Validators
{
    /// <summary>
    /// Ensures that an ICollection function argument is not empty
    /// </summary>
    public class NotEmpty :IPreconditionValidator<ICollection>
    {
        public bool IsValid(ICollection value)
        {
            return value.Count > 0;
        }
    }
}
