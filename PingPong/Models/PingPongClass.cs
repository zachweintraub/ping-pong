namespace PingPong
{
  public class PingPongClass
  {
    private string UserInput = "";

    public string GetUserInput()
    {
      return UserInput;
    }

    public void SetUserInput(string str)
    {
      UserInput = str;
    }

    public bool CheckNumber()
    {
      if (int.TryParse(UserInput, out int result))
      {
        if (result > 0)
        {
          return true;
        }
        else return false;
      }
      else return false;
    }

    public string ConvertInput(int number)
    {
      if (number % 3 ==0 && number % 5==0)
      {
        return "ping-pong";
      }
      else if (number % 3 == 0)
      {
        return "ping";
      }
      else if (number % 5 == 0)
      {
        return "pong";
      }

      string output = number.ToString();
      return output;

    }
  }
}




// outputNumber(num) {
//   if (num % 5 = 0) {
//     return "ping-pong";
//   } else if (num % 3 = 0) {
//     return 2;
//   } else {
//     return -1;
//   }
// }
