using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AchmeaTestss
{
    [TestClass]
    public class UnitTest1
    {
        //yes
        [TestMethod]
        public void TestMethod1()
        {
            int hello = 1;

            Assert.AreEqual(hello, 2);
        }
    }
}
