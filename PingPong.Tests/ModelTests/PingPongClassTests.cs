using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongClassTest
  {
    [TestMethod]
    public void PingPongDisplay_UserInputsNumber_ChecksForInt()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual(true, testPingPongClass.PingPongDisplay("10"));
      Assert.AreEqual(false, testPingPongClass.PingPongDisplay("hello"));
    }
  }
}
