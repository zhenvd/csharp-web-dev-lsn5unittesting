using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)

        /*[TestMethod]*/
        /*public void emptyTest()
        {
            Assert.AreEqual(1, 1);
        }*/
        //TODO: constructor sets gasTankLevel properly


        //TODO: gasTankLevel is accurate after driving within tank range
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range

        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            
            Car test_car1 = new Car("Toyota", "Prius", 10, 50);
            double max_distance = test_car1.MilesPerGallon * test_car1.GasTankLevel; //500
            test_car1.Drive(501); //500 mile tank because 10 tank * 50 mpg = 500
            Assert.AreEqual(test_car1.GasTankLevel, 0, .001); //should be throw exception
        }
        //TODO: can't have more gas than tank size, expect an exception

        //figure out tank size
        //try to put more gas in than tank size
        //compare
        [TestMethod]
        public void TestGasOverfillException()
        {
            Car test_car1 = new Car("Toyota", "Prius", 10, 50);
            test_car1.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");

        }
    }
}
