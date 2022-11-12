//문제내용

//문자열 다듬기
//소문자와 대문자로 구성된 문자열 s가 주어집니다.
//올바른 문자열은 두 개의 인접한 문자 s[i]와 s[i + 1]가 아래의 경우가 없는 문자열입니다.
//0 <= i <= s.length - 2
//s[i]는 소문자이고 s[i + 1]은 동일한 문자이지만 대문자이거나 그 반대입니다.
//문자열을 올바르게 만들기 위해 문자열이 잘못된 두 개의 인접 문자를 선택하고 제거할 수 있습니다. 문자열이 올바르게 될 때까지 계속 이 작업을 수행하면 됩니다.
//문자열을 올바륵 만든 후 반환합니다. 주어진 제약 조건 하에서 답은 고유할 것을 보장합니다.
//빈 문자열 또한 올바릅니다.
//
//예 1:
//입력: s = "leEeetcode"
//출력: "leetcode"
//설명: 첫 번째 단계에서 i = 1 또는 i = 2를 선택하면 "leEetcode"가 "leetcode"로 축소됩니다.
//
//예 2:
//입력: s = "abBAcC"
//출력: ""
//설명: 가능한 시나리오가 많으며 모두 같은 대답으로 이어집니다. 예를 들어:
//"abBAcC" --> "aAcC" --> "cC" --> ""
//"abBAcC" --> "abBA" --> "aA" --> ""


class String_Great
{
 //   static void Main()
 //   {
 //       Console.WriteLine(Makegood("avcCVA"));
 //   }
    public static string Makegood(string s)
    {
    frist:
        if (s.Length < 2)
        {
            return s;
        }
        else
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                var currentNum = Convert.ToInt32(s[i]);
                var nextNum = Convert.ToInt32(s[i + 1]);

                if (Math.Abs(currentNum - nextNum) == 32)
                {
                    s = s.Remove(i, 2);
                    goto frist;
                }
            }
            return s;
        }
    }
}