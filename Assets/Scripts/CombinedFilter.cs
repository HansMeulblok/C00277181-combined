public class CombinedFilter
{
  public static int[] combinedFilter(int[] xs)
  {
    return Xor21Filter.Xor21s(FactFilter.Factorial(xs));
  }
}
