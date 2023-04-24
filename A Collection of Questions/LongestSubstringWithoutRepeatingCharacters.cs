public class LongestSubstringWithoutRepeatingCharacters {
    public int _LengthOfLongestSubstring(string s) {
    if (s.Length <= 1)
        return s.Length;

    Dictionary<string,int> asd = new Dictionary<string,int>();

    int result = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (!asd.ContainsKey(s[i].ToString()))
        {
            asd.Add(s[i].ToString(),i);
            result = result < asd.Count ? asd.Count : result;
        }
        else
        { 
            i = asd[s[i].ToString()];
            asd.Clear();
        }

    }
    return result;  
  }
}