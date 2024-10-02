using CodeWars._5Kyu.Greed_is_Good;

namespace CodeWars.Tests._5Kyu.Greed_is_Good;

[Trait("Category", "5Kyu_GreedIsGood")]
public class ScoreCheckerTest
{
  [Fact]
  public static void ShouldBeWorthless()
  {
    Assert.True(0 == ScoreChecker.Score(new int[] { 2, 3, 4, 6, 2 }));
  }

  [Fact]
  public static void ShouldValueTriplets()
  {
    Assert.True(400 == ScoreChecker.Score(new int[] { 4, 4, 4, 3, 3 }));
  }

  [Fact]
  public static void ShouldValueMixedSets()
  {
    Assert.True(450 == ScoreChecker.Score(new int[] { 2, 4, 4, 5, 4 }));
  }
}
