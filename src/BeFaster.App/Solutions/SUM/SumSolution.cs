using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            return IsValidNumber(x) && IsValidNumber(y)
                ? x + y
                : -1;
        }

        private static bool IsValidNumber(int number)
        {
            return number >= 0 && number <= 100;
        }
    }
}
