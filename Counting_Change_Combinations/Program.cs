using System;

namespace Counting_Change_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCombinations(4, new int[2] { 1, 2 }));
        }
        public static int CountCombinations(int money, int[] coins)
        {
            if (money < 0) return 0;
            else if (coins == null || coins.Length == 0) return 0;

            int[] dp = new int[money + 1];
            dp[0] = 1;
            for (int i = 0; i < coins.Length; ++i)
            {
                for (int j = coins[i]; j <= money; ++j)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }
            return dp[money];
        }
    }
}
