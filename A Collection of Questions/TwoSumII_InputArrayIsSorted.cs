public class TwoSumII_InputArrayIsSorted {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[0];
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if(numbers[i]+numbers[j] == target){
                    int[] soultion = {i+1,j+1};
                    return soultion;
                }
            }
        }
        return result;
    }
}   