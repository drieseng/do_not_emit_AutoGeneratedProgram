using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
#pragma warning disable CA1515 // Consider making public types internal
    public class Class1
#pragma warning restore CA1515 // Consider making public types internal
    {
        [TestMethod]
        public void AlwaysTrue()
        {
            Assert.IsTrue(true);
        }
    }
}
