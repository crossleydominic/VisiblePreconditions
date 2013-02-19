using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    /// <summary>
    /// Postcondition that for an argument that has a single validator
    /// </summary>
    /// <typeparam name="TArg">
    /// The type of the argument
    /// </typeparam>
    /// <typeparam name="TFunc1">
    /// The type of the validator
    /// </typeparam>
    /// <remarks>
    /// We declare this type as a struct so that even if we return an explicit
    /// null we'll still execute the implicit conversion operator.
    /// If this type was a class then the implicit conversion operator DOES NOT get invoked
    /// when explicitly returning  null.
    /// 
    /// This does mean that we can't derive from other types which is why we have to reinvent
    /// the wheel for Pre/Postcondition types that take more validator arguments 
    /// </remarks>
    public struct Postcondition<TArg, TFunc1>
        where TFunc1 : IConditionValidator<TArg>
    {
        #region Static members

        /// <summary>
        /// The list of validator types
        /// </summary>
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        #endregion

        #region Private members

        /// <summary>
        /// The Condition type that will perform the validation
        /// (We cannot derivce from it because this type is a struct)
        /// </summary>
        private Condition<TArg> _postcondition;

        #endregion

        #region Public Properties

        /// <summary>
        /// Invokes that postcondition checks on the value and, if valid, returns the value
        /// </summary>
        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        #endregion

        #region Conversion operators

        /// <summary>
        /// Automatically wraps a return value with a post condition
        /// </summary>
        public static implicit operator Postcondition<TArg, TFunc1>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        /// <summary>
        /// Automatically converts the wrapped value back into the normal value
        /// after invoking the post condition checks.
        /// </summary>
        public static implicit operator TArg(Postcondition<TArg, TFunc1> postcondition)
        {
            return postcondition.Value;
        }

        #endregion
    }

    #region Two validators

    public struct Postcondition<TArg, TFunc1, TFunc2>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Three validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Four validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Five validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Six validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Seven validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>
    where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

    #region Eight validators

    public struct Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>
        where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1) };

        private Condition<TArg> _postcondition;

        public TArg Value
        {
            get { return _postcondition.Value; }
        }

        public static implicit operator Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>(TArg arg)
        {
            return new Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>()
            {
                _postcondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        public static implicit operator TArg(Postcondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8> postcondition)
        {
            return postcondition.Value;
        }
    }

    #endregion

}
