using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sprint_0_Warm_Up;

namespace SprinZeroTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Engine E = new Engine();

            Assert.IsNotNull(E);

            Airplane A = new Airplane();

            Assert.IsNotNull(A);
            Assert.AreEqual(A.Name, "OOPFlying.Airplane");
            Assert.AreEqual(A.MaxAltitude, 41000);
            Assert.AreEqual(A.Isflying, false);

            
            


        }
    }
}
