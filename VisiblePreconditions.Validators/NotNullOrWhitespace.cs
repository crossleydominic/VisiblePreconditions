using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiblePreconditions.Framework;

namespace VisiblePreconditions.Validators
{
    public class NotNullOrWhitespace : IPreconditionValidator<string>
    {
        public bool IsValid(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
