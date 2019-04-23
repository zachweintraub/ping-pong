namespace PingPong
{
  public class PingPongClass
  {
    public bool PingPongDisplay(string userNumber)
    {
      return int.TryParse(userNumber, out int result);
    }
  }
}
