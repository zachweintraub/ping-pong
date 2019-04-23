using System;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      PingPongClass pingPong = new PingPongClass();
      Console.WriteLine("Enter a number");
      pingPong.SetUserInput(Console.ReadLine());
      if (!pingPong.CheckNumber())
      {
        Console.WriteLine("Sorry, that's not a number.");
        Main();
      }
      else
      {
        int userNumberInt = int.Parse(pingPong.GetUserInput());
        for (int i = 1; i < userNumberInt; i++)
        {
          Console.WriteLine(pingPong.ConvertInput(i));
        }
      }

    }
  }
}
