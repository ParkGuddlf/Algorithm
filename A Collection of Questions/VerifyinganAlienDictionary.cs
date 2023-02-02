//https://leetcode.com/problems/verifying-an-alien-dictionary/description/

public class VerifyinganAlienDictionary{
        public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        for (int i = 0; i < order.Length; i++)
        {
            dic.Add(order[i], i);
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            var firstWord = words[i];
           var secondWord = words[i + 1];
            for (int j = 0; j < Math.Min(firstWord.Count(), secondWord.Count()); j++)
            {

                if (firstWord == secondWord)
                    break;
                if (dic[firstWord.ElementAt(j)] < dic[secondWord.ElementAt(j)])
                    break;
                else if (dic[firstWord.ElementAt(j)] > dic[secondWord.ElementAt(j)])
                    return false;
                if (j == Math.Min(firstWord.Count(), secondWord.Count())-1 && firstWord.Count() < secondWord.Count())
                    break;
                else if(j == Math.Min(firstWord.Count(), secondWord.Count())-1 && firstWord.Count() > secondWord.Count())
                    return false;
            }
    
        }
        return true;
    }
}