public class CombinationSum
{
    public IList<IList<int>> _CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> _combinationSum = new List<IList<int>>();
        IList<int> currentList = new List<int>();
        SearchSoultion(candidates, 0, currentList, target, _combinationSum);
        return _combinationSum;
    }
    void SearchSoultion(int[] candidates, int index, IList<int> currentList, int target, IList<IList<int>> combinationSum)
    {
        if (currentList.Sum() == target)
        {
            combinationSum.Add(currentList);
            return;
        }

        if (currentList.Sum() > target || candidates.Length < index + 1)
            return;

        IList<int> newCurrentList = new List<int>(currentList);
        newCurrentList.Add(candidates[index]);
        SearchSoultion(candidates, index, newCurrentList, target, combinationSum);
        SearchSoultion(candidates, index + 1, currentList, target, combinationSum);
    }
}