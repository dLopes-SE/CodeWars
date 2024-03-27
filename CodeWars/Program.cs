namespace CodeWars
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var seconds = 45296;
      Console.WriteLine(seconds - (seconds / 3600 * 3600) - ((seconds - (seconds / 3600) * 3600) / 60 * 60));
      Console.WriteLine(_5Kyu.HumanReadableTime.TimeFormat.GetReadableTime(86400));
      //Console.WriteLine(_6Kyu.Kata.SpinWords("Hey fellow warriors"));
    }
  }
}
