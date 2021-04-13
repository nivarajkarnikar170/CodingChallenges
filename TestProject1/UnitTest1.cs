using ConsoleApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Counting c = new Counting();
            Assert.AreEqual(4, c.smallestPositiveInt(new int[] { 1, 2, 3 }));
        }
    }
}
