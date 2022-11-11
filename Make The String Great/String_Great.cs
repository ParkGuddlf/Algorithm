class String_Great
{
    static void Main()
    {
        Console.WriteLine(Makegood("avcCVA"));
    }
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