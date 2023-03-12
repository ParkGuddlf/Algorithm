//https://leetcode.com/problems/roman-to-integer/
public class RomantoInteger {
    public int RomanToInt(string s) {
            var _num = 0;
        for (int i = 0; i < s.Length-1; i++)
        {
            if (CharToInt(s[i]) < CharToInt(s[i+1]))
           {
            _num -= CharToInt(s[i]);
           }
           else
           {
               _num += CharToInt(s[i]);
           }        
        }
        return _num+CharToInt(s.Last());
    }
    int CharToInt(char s)
{
    switch (s)
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            return 0;
    }
}
}