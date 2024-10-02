using CodeWars._6Kyu.BouncingBalls;

namespace CodeWars.Tests._6Kyu.BouncingBalls;

[Trait("Category", "6kyu_bouncingBalls")]
public class BouncingBallTests
{
  [Fact]
  public void Test1()
  {
    Assert.Equal(3, BouncingBall.bouncingBall(3.0, 0.66, 1.5));
  }
  [Fact]
  public void Test2()
  {
    Assert.Equal(15, BouncingBall.bouncingBall(30.0, 0.66, 1.5));
  }
}