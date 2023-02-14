//https://leetcode.com/problems/shuffle-the-array/

public class ShuffletheArray {
    public int[] Shuffle(int[] nums, int n) {
        int[] numssss = new int[nums.Length];
        for (int i = 0; i < n; i++)
        {
        numssss[i*2] = nums.Take(n).ToArray()[i];
        numssss[i*2+1] = nums.TakeLast(n).ToArray()[i];
        }
        return numssss;
    }
}