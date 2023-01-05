// https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/
//0 인덱스 정수 배열 tasks가 주어집니다. 여기서 tasks[i]는 작업의 난이도를 나타냅니다. 각 라운드에서 동일한 난이도의 작업을 2개 또는 3개 완료할 수 있습니다.
//모든 작업을 완료하는 데 필요한 최소 라운드를 반환하거나 모든 작업을 완료할 수 없는 경우 -1을 반환합니다.
public class MinimunRounds
{
    public static int MinimumRounds(int[] tasks)
    {
         Dictionary<int, int> numsDic = new Dictionary<int, int>();
         foreach (var item in tasks)
         {
             if (!numsDic.ContainsKey(item))
                 numsDic.Add(item, 1);
             else
                 numsDic[item] += 1;
         }
         if (numsDic.ContainsValue(1))
             return -1;

         int totalwork = 0;
         foreach (var num in numsDic)
         {
             if (num.Value < 3)
                 totalwork += 1;
             else
             {
                 totalwork += num.Value / 3;
                 if (num.Value % 3 != 0)
                     totalwork += 1;
             }


         }
         return totalwork;
    }

}