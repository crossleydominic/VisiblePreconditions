using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    public struct Precondition<TArg, TFunc1>
            where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Precondition<TArg> _precondition;

        public TArg Value { get { return _precondition.Value; } }

        public static implicit operator Precondition<TArg, TFunc1>(TArg arg)
        {
            return new Precondition<TArg, TFunc1>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
}
