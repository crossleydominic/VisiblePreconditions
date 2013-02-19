using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    /// <summary>
    /// Condition class that encapsulates the logic of invoking the 
    /// validators on the value
    /// </summary>
    /// <typeparam name="TArg">
    /// The argument type that will be checked against the conditions
    /// </typeparam>
    internal class Condition<TArg>
    {
        #region Private members
        
        /// <summary>
        /// The value that will be checked to ensure it complies with the conditions
        /// </summary>
        private TArg _value;
        
        /// <summary>
        /// Whether or not the value is valid (if it's been validated)
        /// </summary>
        private bool? _isValid;

        /// <summary>
        /// The exception that should be thrown if the value is not valid
        /// </summary>
        private Exception _validationException;

        /// <summary>
        /// A set of validators that will be applied to the value
        /// </summary>
        private IEnumerable<IConditionValidator<TArg>> _validationFunctions;

        #endregion

        #region Constructors
        
        /// <summary>
        /// Construct a new Condition wrapping the supplied value
        /// </summary>
        /// <param name="value">
        /// The value that will be checked
        /// </param>
        /// <param name="validationTypes">
        /// The Condition validators that will be applied to the value
        /// </param>
        public Condition(TArg value, List<Type> validationTypes)
        {
            #region Input Validation

            if (validationTypes == null)
            {
                throw new ArgumentNullException("validationTypes");
            }

            #endregion

            _value = value;
            _isValid = null;
            _validationFunctions = validationTypes.Select(v => (IConditionValidator<TArg>)Activator.CreateInstance(v));
            _validationException = null;
        }

        #endregion

        #region Public Properties
        
        /// <summary>
        /// Returns the value if it passes all conditions checks.  If the value does not pass the checks then 
        /// an exception is generated.
        /// </summary>
        public TArg Value
        {
            get
            {
                if (!_isValid.HasValue)
                {
                    IConditionValidator<TArg> failingValidator = _validationFunctions.FirstOrDefault(v => !v.IsValid(_value));

                    if (failingValidator == null)
                    {
                        _isValid = true;
                        _validationException = null;
                    }
                    else
                    {
                        _isValid = false;
                        _validationException = new ConditionViolatedException(
                            typeof(TArg),
                            (_value == null ? "null" : _value.ToString()),
                            failingValidator.GetType());
                    }
                }

                if (_isValid == false)
                {
                    throw _validationException;
                }

                return _value;
            }
        }

        #endregion
    }
}
