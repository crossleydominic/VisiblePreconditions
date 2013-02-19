using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VisiblePreconditions.Framework.Tests
{
    [TestFixture]
    public class ConditionTests
    {
        public class AlwaysSucceedsValidator : IConditionValidator<int>
        {
            public bool IsValid(int value)
            {
                return true;
            }
        }

        public class AlwaysFailsValidator : IConditionValidator<int>
        {
            public bool IsValid(int value)
            {
                return false;
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ValidatorsNull()
        {
            Condition<object> condition = new Condition<object>(new object(), null);
        }

        [Test]
        [ExpectedException(typeof(ConditionViolatedException))]
        public void Value_ConditionFails()
        {
            Condition<int> condition = new Condition<int>(1, new List<Type>() { typeof(AlwaysFailsValidator)});

            int value = condition.Value;
        }

        [Test]
        public void Value_ConditionDoesNotFail()
        {
            Condition<int> condition = new Condition<int>(1, new List<Type>() { typeof(AlwaysSucceedsValidator) });

            Assert.AreEqual(1, condition.Value);
        }
    }
}
