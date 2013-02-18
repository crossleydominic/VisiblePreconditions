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
        private static readonly List<Type> _genericTypes = new List<Type>() {typeof (TFunc1)};

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1>(TArg arg)
        {
            return new Precondition<TArg, TFunc1>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }

    public struct Precondition<TArg, TFunc1, TFunc2>
        where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3>
       where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>
       where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>
       where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>
       where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>
       where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6), typeof(TFunc7) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>
        where TFunc1 : IPreconditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6), typeof(TFunc7), typeof(TFunc8) };

        private Precondition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>()
            {
                _precondition = new Precondition<TArg>(arg, _genericTypes)
            };
        }
    }
}