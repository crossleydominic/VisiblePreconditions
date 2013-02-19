using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    /// <summary>
    /// Precondition that for an argument that has a single validator
    /// </summary>
    /// <typeparam name="TArg">
    /// The type of the argument
    /// </typeparam>
    /// <typeparam name="TFunc1">
    /// The type of the validator
    /// </typeparam>
    /// <remarks>
    /// We declare this type as a struct so that even if we call a function by explicitly
    /// passing null we'll still execute the implicit conversion operator.
    /// If this type was a class then the implicit conversion operator DOES NOT get invoked
    /// when calling methods and explicitly passing null.
    /// 
    /// This does mean that we can't derive from other types which is why we have to reinvent
    /// the wheel for Precondition types that take more validator arguments 
    /// </remarks>
    public struct Precondition<TArg, TFunc1>
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
        private Condition<TArg> _precondition;

        #endregion

        #region Public Properties
        
        /// <summary>
        /// Invokes that precondition checks on the value and, if valid, returns the value
        /// </summary>
        public TArg Value
        {
            get { return _precondition.Value; }
        }

        #endregion

        #region Conversion operators
        
        /// <summary>
        /// Allow arguments to be automatically converted
        /// </summary>
        public static implicit operator Precondition<TArg, TFunc1>(TArg arg)
        {
            return new Precondition<TArg, TFunc1>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }

        #endregion
    }

    #region Two validators

    public struct Precondition<TArg, TFunc1, TFunc2>
        where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Three validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3>
       where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Four validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>
       where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Five validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>
       where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Six validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>
       where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Seven validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>
       where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6), typeof(TFunc7) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion

    #region Eight validators

    public struct Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>
        where TFunc1 : IConditionValidator<TArg>
    {
        private static readonly List<Type> _genericTypes = new List<Type>() { typeof(TFunc1), typeof(TFunc2), typeof(TFunc3), typeof(TFunc4), typeof(TFunc5), typeof(TFunc6), typeof(TFunc7), typeof(TFunc8) };

        private Condition<TArg> _precondition;

        public TArg Value
        {
            get { return _precondition.Value; }
        }

        public static implicit operator Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>(TArg arg)
        {
            return new Precondition<TArg, TFunc1, TFunc2, TFunc3, TFunc4, TFunc5, TFunc6, TFunc7, TFunc8>()
            {
                _precondition = new Condition<TArg>(arg, _genericTypes)
            };
        }
    }

    #endregion
}