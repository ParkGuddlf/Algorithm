/*문자열의 첫 번째 고유 문자
문자열 s가 주어질 때, 그 안에서 반복되지 않는 첫 번째 문자를 찾고 해당 인덱스를 반환합니다. 존재하지 않으면 -1을 반환합니다.

입력: s = "leetcode"
출력: 0

입력: s = "loveleetcode"
출력: 2

입력: s = "aabb"
출력: -1*/
//https://leetcode.com/problems/first-unique-character-in-a-string/
using System.Collections;

public class FUCIS
{
    public static int FirstUniqChar(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
             if (!dic.ContainsKey(s[i]))
            {
                dic.Add(s[i], 1);                
            }
            else
            {
                dic[s[i]] += 1;
            }
        }
        for (int j = 0; j < s.Length; j++)
        {
            if(dic[s[j]] == 1){                
                return j;
            }                
        }
        return -1;          
        
    }
}