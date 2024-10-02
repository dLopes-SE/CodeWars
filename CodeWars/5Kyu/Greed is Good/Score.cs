namespace CodeWars._5Kyu.Greed_is_Good;

public static class ScoreChecker
{
  public const int TRIPLE_OCCURRENCES = 3;
  public static int Score(int[] dice)
  {
    var score = 0;

    // Increase score + remove the sequece of 3 numbers, so that we can count the remaining at the end
    if (dice.Count(n => n == 1) >= TRIPLE_OCCURRENCES)
    {
      score += 1000;
      dice = RemoveDices(dice, 1);
    }

    // Increase score + remove the sequece of 3 numbers, so that we can count the remaining at the end
    if (dice.Count(n => n == 5) >= TRIPLE_OCCURRENCES)
    {
      score += 500;
      dice = RemoveDices(dice, 5);
    }

    if (dice.Count(n => n == 6) >= TRIPLE_OCCURRENCES)
      score += 600;

    if (dice.Count(n => n == 4) >= TRIPLE_OCCURRENCES)
      score += 400;

    if (dice.Count(n => n == 3) >= TRIPLE_OCCURRENCES)
      score += 300;

    if (dice.Count(n => n == 2) >= TRIPLE_OCCURRENCES)
      score += 200;


    // Now incresed the score with the remaining 1s and 5s
    score += 100 * dice.Count(n => n == 1);
    score += 50 * dice.Count(n => n == 5);

    return score;
  }

  public static int[] RemoveDices(int[] dice, int no)
  {
    var countRemoved = 0;
    return dice.Where(n =>
    {
      if (n != no)
        return true;

      if (countRemoved < TRIPLE_OCCURRENCES)
      {
        countRemoved++;
        return false;
      }

      return true;
    }).ToArray();
  }
}
