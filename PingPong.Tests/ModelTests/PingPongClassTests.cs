using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongClassTest
  {
    [TestMethod]
    public void CheckNumber_UserInputsNumber_ChecksForInt()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual(true, testPingPongClass.CheckNumber("5"));
      Assert.AreEqual(false, testPingPongClass.CheckNumber("hello"));
    }

    [TestMethod]
    public void ConvertInput_UserInputsNonDivisibleNumber_OutputNumberAsString()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual("2", testPingPongClass.ConvertInput(2));
    }

    [TestMethod]
    public void ConvertInput_UserInputs3DivisibleNumber_OutputPing()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual("ping", testPingPongClass.ConvertInput(3));
    }

    [TestMethod]
    public void ConvertInput_UserInputs5DivisibleNumber_OutputPing()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual("pong", testPingPongClass.ConvertInput(5));
    }

    [TestMethod]
    public void ConvertInput_UserInputs5Or3DivisibleNumber_OutputPing()
    {
      PingPongClass testPingPongClass = new PingPongClass();
      Assert.AreEqual("ping-pong", testPingPongClass.ConvertInput(15));
    }

  }
}
