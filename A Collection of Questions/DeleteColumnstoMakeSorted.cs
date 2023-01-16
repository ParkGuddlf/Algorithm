
//https://leetcode.com/problems/delete-columns-to-make-sorted/description/
public class DeleteColumnstoMakeSorted {
    public int MinDeletionSize(string[] strs) {
        int deletArrayCount = 0;
        for (int i = 0; i < strs[0].Length; i++)
        {
            var asd = strs.Select(n=>n[i]);
            if (!Enumerable.SequenceEqual(asd, asd.OrderBy(n => n)))
                deletArrayCount++;

        }
        return deletArrayCount;
    }
}