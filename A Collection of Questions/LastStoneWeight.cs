//https://leetcode.com/problems/last-stone-weight/

public class LastStoneWeight {
    public int _LastStoneWeight(int[] stones) {
    List<int> orderByAarry = stones.ToList();
    while (orderByAarry.Count > 1)
    {
        orderByAarry = orderByAarry.OrderByDescending(x => x).ToList();
        orderByAarry.Add(orderByAarry[0] - orderByAarry[1]);

        if (orderByAarry.Count > 2)
        {
            orderByAarry.RemoveAt(0);
            orderByAarry.RemoveAt(0);
        }
        else
        {
            return orderByAarry[0] - orderByAarry[1];
        }
    }
    return orderByAarry.Sum();
        
    }
}