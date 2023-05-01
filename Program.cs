Console.WriteLine(IsPalindrome(123));

bool IsPalindrome(int x)
{
    string xString = x.ToString();


    char[] stringsArray = xString.ToArray();
    char[] stringsReverseArray = xString.Reverse().ToArray();


    if (stringsArray != stringsReverseArray)
            return false;
    
    return true;
}