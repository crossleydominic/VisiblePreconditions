using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiblePreconditions.Framework
{
    public class Precondition<TArg>
    {
        private TArg _value;

        private bool _hasBeenValidated;
        private bool _isValid;
        private Exception _validationException;

        private List<IPreconditionValidator<TArg>> _validationFunctions;

        public Precondition(TArg value, List<Type> validationTypes)
        {
            _value = value;
            _hasBeenValidated = false;
            _isValid = false;
            _validationFunctions = new List<IPreconditionValidator<TArg>>();
            _validationException = null;

            foreach (Type t in validationTypes)
            {
                _validationFunctions.Add((IPreconditionValidator<TArg>) Activator.CreateInstance(t));
            }
        }

        public TArg Value
        {
            get
            {
                if (!_hasBeenValidated)
                {
                    _hasBeenValidated = true;

                    IPreconditionValidator<TArg> failingValidator = _validationFunctions.FirstOrDefault(v => !v.IsValid(_value));

                    if (failingValidator == null)
                    {
                        _isValid = true;
                        _validationException = null;
                    }
                    else
                    {
                        _isValid = false;
                        _validationException = new PreconditionViolatedException(
                            typeof(TArg),
                            (_value == null ? "null" : _value.ToString()),
                            failingValidator.GetType());
                    }
                }

                if (!_isValid)
                {
                    throw _validationException;
                }

                return _value;
            }
        }
    }
}
