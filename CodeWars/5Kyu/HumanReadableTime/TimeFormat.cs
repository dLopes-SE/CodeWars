namespace CodeWars._5Kyu.HumanReadableTime
{
  public static class TimeFormat
  {
    public static string GetReadableTime(int seconds)
    {
      var t = TimeSpan.FromSeconds(seconds);
      return $"{(int)t.TotalHours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";
    }                                                                                                                                                                                   
  }
}
