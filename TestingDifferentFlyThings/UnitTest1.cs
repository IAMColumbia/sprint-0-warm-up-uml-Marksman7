using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sprint_0_Warm_Up;
namespace TestingDifferentFlyThings
{

    

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Airplane A = new Airplane();

            Assert.IsNotNull(A);
            Assert.AreEqual(A.Name, "OOPFlying.Airplane");
            Assert.AreEqual(A.Isflying, false);
            Assert.AreEqual(A.MaxAltitude, 41000);
            Assert.AreEqual(A.CurrentAltitude, 0);

            A.TakeOff();
            A.ToString();
            A.StartEngine();
            A.StopEngine();
            A.About();
            A.FlyUp(100);
            A.FlyDown(100);

            
        }

        /*public void AerialVheilceClass()
        {
            var All = Activator.CreateInstance<AerialVehicle>();
        }*/

    }
}
