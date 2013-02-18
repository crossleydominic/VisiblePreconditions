using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VisiblePreconditions.Validators;

namespace VisiblePreconditions.Validator.Tests
{
    [TestFixture]
    public class NotNullTests
    {
        [Test]
        public void NotNull_ArgumentNull()
        {
            NotNull validator = new NotNull();

            Assert.IsFalse(validator.IsValid(null));
        }

        [Test]
        public void NotNull_ArgumentNotNull()
        {
            NotNull validator = new NotNull();

            Assert.IsTrue(validator.IsValid(new object()));
        }
    }
}
