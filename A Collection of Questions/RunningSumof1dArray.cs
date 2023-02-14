//https://leetcode.com/problems/running-sum-of-1d-array/
public class RunningSumof1dArray {
    public int[] RunningSum(int[] nums) {
        int[] _return = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            _return[i] = nums.Take(i+1).Sum();
        }
        return _return;
    }
}