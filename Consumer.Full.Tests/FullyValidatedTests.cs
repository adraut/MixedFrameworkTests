using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Consumer.Full.Tests
{
    [TestClass]
    public class FullyValidatedTests
    {
        [TestMethod]
        public void Validate()
        {
            var sut = new FullyValidated();
            var result = sut.Validate();
            Assert.IsNotNull(result);
        }
    }
}
