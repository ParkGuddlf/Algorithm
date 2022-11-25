public class FizzBuzz {
    public static IList<string> Fizz_Buzz(int n) {
         string[] _array = new string[n];
        for (int i = 1; i < _array.Length+1; i++)
        {
             if(i%5==0 && i%3==0)
                _array[i-1] = "FizzBuzz";
            else if(i%5==0)
                _array[i-1] = "Buzz";
            else if(i%3==0)
                _array[i-1] = "Fizz";
            else
                _array[i-1] = i.ToString();
        
            Console.WriteLine(_array[i-1]);
        }
        
        return _array;
    }
}