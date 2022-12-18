//https://leetcode.com/problems/house-robber/
public class Rob
{
    public static int solution(int[] num)
    {
        if (num.Length == 0)
            return 0;
        else if (num.Length < 3)
            return num.Max();
        else
            num[1] = Math.Max(num[0], num[1]);
            for (int i = 2; i < num.Length; i++)
            {
                num[i] = Math.Max(num[i] + num[i-2], num[i-1]);
                Console.WriteLine(num[i]);
            }
            return num[num.Length-1];
    }
}