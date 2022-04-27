using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShowSpec()
        {
            Computer dell = new Computer("Windows11", "i5", 2022);
            Assert.AreEqual("Windows11 : i5 : 2022", dell.ShowSpecs());
        }

        [TestMethod]
        public void TestSwitchPower()
        {
            Computer dell = new Computer("Windows11", "i5", 2022);
           // dell.SwitchPower();
            Assert.IsTrue(dell.IsOn);
        }
    }
}
