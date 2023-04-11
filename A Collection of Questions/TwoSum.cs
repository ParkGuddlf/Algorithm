public class TwoSum {
    public int[] _TwoSum(int[] nums, int target) {
        int[] asda =  new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
             {
                 if(nums[i]+nums[j] == target)
                 {
                     asda[0] = i;
                     asda[1] = j;
                     return asda;
                 }
            }
        }
        return null;
    }
}