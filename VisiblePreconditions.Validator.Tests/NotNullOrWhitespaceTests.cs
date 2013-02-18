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
    public class NotNullOrWhitespaceTests
    {
        [Test]
        public void NotNullOrWhitespace_ArgumentNull()
        {
            NotNullOrWhitespace validator = new NotNullOrWhitespace();

            Assert.IsFalse(validator.IsValid(null));
        }

        [Test]
        public void NotNullOrWhitespace_ArgumentEmpty()
        {
            NotNullOrWhitespace validator = new NotNullOrWhitespace();

            Assert.IsFalse(validator.IsValid(string.Empty));
        }

        [Test]
        public void NotNullOrWhitespace_ArgumentSpace()
        {
            NotNullOrWhitespace validator = new NotNullOrWhitespace();

            Assert.IsFalse(validator.IsValid(" "));
        }

        [Test]
        public void NotNullOrWhitespace_ArgumentTab()
        {
            NotNullOrWhitespace validator = new NotNullOrWhitespace();

            Assert.IsFalse(validator.IsValid("\t"));
        }

        [Test]
        public void NotNullOrWhitespace_ArgumentNotNullOrWhitespace()
        {
            NotNullOrWhitespace validator = new NotNullOrWhitespace();

            Assert.IsTrue(validator.IsValid("somestring"));
        }
    }
}
