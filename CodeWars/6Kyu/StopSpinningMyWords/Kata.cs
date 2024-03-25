namespace CodeWars._6Kyu
{
  public class Kata
  {
    public static string SpinWords(string sentence)
    {
      return string.Join(' ', sentence.Split(" ").Select(w => w.Length >= 5 ? new string(w.Reverse().ToArray()) : w).ToList());
    }
  }
}
