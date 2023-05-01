public class MultiplyStrings {
    public string Multiply(string num1, string num2) {
        int m = num1.Length;
        int n = num2.Length;

        int[] result = new int[m + n];
        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                result[j + i + 1] += mul % 10;
                result[j + i] += mul / 10;
            }
        }
        for (int i = m + n - 1; i >= 0; i--)
        {
            if (i != 0)
                result[i - 1] += result[i] / 10;
            result[i] = result[i] % 10;
        }
        if(result.Sum() ==0)
            return "0";
        string answer = "";
        var k = result[0] == 0 ? 1 : 0;

        for (int i = k; i <m+n; i++)
        {
            answer += result[i];
        }
        return answer;
    }
}