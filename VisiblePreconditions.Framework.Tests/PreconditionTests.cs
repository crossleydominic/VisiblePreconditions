using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VisiblePreconditions.Framework.Tests
{
    [TestFixture]
    public class PreconditionTests
    {
        public class AlwaysSucceedsValidator : IPreconditionValidator<int>
        {
            public bool IsValid(int value)
            {
                return true;
            }
        }

        public class AlwaysFailsValidator : IPreconditionValidator<int>
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
            Precondition<object> precondition = new Precondition<object>(new object(), null);
        }

        [Test]
        [ExpectedException(typeof(PreconditionViolatedException))]
        public void Value_PreconditionFails()
        {
            Precondition<int> precondition = new Precondition<int>(1, new List<Type>() { typeof(AlwaysFailsValidator)});

            int value = precondition.Value;
        }

        [Test]
        public void Value_PreconditionDoesNotFail()
        {
            Precondition<int> precondition = new Precondition<int>(1, new List<Type>() { typeof(AlwaysSucceedsValidator) });

            Assert.AreEqual(1, precondition.Value);
        }

        [Test]
        public void Precondition_TypeCastsAndEvaluatesCorrectly()
        {
            Precondition<int, AlwaysSucceedsValidator> precondition = 5;

            Assert.AreEqual(5, precondition.Value);
        }

        [Test]
        public void Precondition_UsableOnDelegates()
        {
            Func<Precondition<int, AlwaysSucceedsValidator>, Precondition<int, AlwaysSucceedsValidator>, int> func = 
                (x, y) => x.Value + y.Value;

            Assert.AreEqual(11, func(5, 6));
        }
    }
}
