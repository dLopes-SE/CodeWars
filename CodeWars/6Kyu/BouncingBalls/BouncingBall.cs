using System.Diagnostics.Metrics;

namespace CodeWars._6Kyu.BouncingBalls
{
  public class BouncingBall
  {
    public static int bouncingBall(double h, double bounce, double window)
    {
      //Float parameter "h" in meters must be greater than 0 -> height of the floor
      //Float parameter "bounce" must be greater than 0 and less than 1 -> bounce rate
      //Float parameter "window" must be less than h. -> window's height, from where the child's mom is looking
      if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
        return -1;

      var count = 1;
      while (h*bounce > window)
      {
        count += 2;
        h *= bounce;
      }

      if (h == window)
        count++;

      return count;
    }
  }
}