
//https://leetcode.com/problems/longest-common-prefix/

public class LongestCommonPrefix
{
    public string _LongestCommonPrefix(string[] strs)
    {
        int strMinValue = strs.Min(e => e.Length);
        string returnStr = strs.First(e => e.Length == strMinValue);

        foreach (var item in strs)
        {
            for (int i = 0; i < returnStr.Length; i++)
            {
                if (item[i] != returnStr[i] && i < strMinValue)
                {
                    strMinValue = i;
                }
            }
        }
        return returnStr.Substring(0, strMinValue);
    }
}