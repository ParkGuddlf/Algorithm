//https://leetcode.com/problems/merge-strings-alternately/

public class MergeStringsAlternately {
    public string MergeAlternately(string word1, string word2) {
        string m_soultion = string.Empty;
        var ad = word1.Length < word2.Length ? word1.Length : word2.Length;
        for (int i = 0; i < ad ; i++)
        {
                m_soultion += (word1[i].ToString()+word2[i].ToString());
        }

        return m_soultion += word1.Length > word2.Length ? word1.Substring(Math.Abs(word2.Length)) : word2.Substring(Math.Abs(word1.Length));
    }
}