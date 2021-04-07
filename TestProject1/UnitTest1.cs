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

            var obj = new MySum();
            Assert.AreEqual(5, obj.sumNums(2, 3));
        }
    }
}
