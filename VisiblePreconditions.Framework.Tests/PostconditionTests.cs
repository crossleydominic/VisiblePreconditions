using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VisiblePreconditions.Framework.Tests
{
    [TestFixture]
    public class PostconditionTests
    {
        [Test]
        public void Precondition_TypeCastsAndEvaluatesCorrectly()
        {
            Postcondition<int, ConditionTests.AlwaysSucceedsValidator> precondition = 5;

            Assert.AreEqual(5, precondition.Value);
        }

        [Test]
        public void Precondition_UsableOnDelegates()
        {
            Func<int, int, Postcondition<int, ConditionTests.AlwaysSucceedsValidator>> func =
                (x, y) => x + y;

            //Automatic casting
            int result = func(5, 6);

            Assert.AreEqual(11, result );
        }
    }
}
