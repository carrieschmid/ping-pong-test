using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace Main.tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]

    public void
    Main_NumberIsDivisableByThreeAndDivisableByFive_True()
    {
      Program testPingPong = new Program();
      Assert.AreEqual(true,testPingPong.Main(15));
    }

    [TestMethod]

    public void
    Main_NumberIsDivisableByThree_True()
    
    {    
      Program testPingPong = new Program();

      Assert.AreEqual(true, testPingPong.Main(9));
    }
  }
}