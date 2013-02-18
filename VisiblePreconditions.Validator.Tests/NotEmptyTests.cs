using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VisiblePreconditions.Validators;

namespace VisiblePreconditions.Validator.Tests
{
    [TestFixture]
    public class NotEmptyTests
    {
        [Test]
        public void IsValid_ArgumentNull()
        {
            NotEmpty validator = new NotEmpty();

            Assert.IsFalse(validator.IsValid(null));
        }

        [Test]
        public void IsValid_ArgumentEmpty()
        {
            NotEmpty validator = new NotEmpty();

            Assert.IsFalse(validator.IsValid(new List<int>()));
        }

        [Test]
        public void IsValid_ArgumentNotEmpty()
        {
            NotEmpty validator = new NotEmpty();

            Assert.IsTrue(validator.IsValid(new List<int>(){1}));
        }
    }
}
