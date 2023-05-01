//https://leetcode.com/problems/add-digits/

public class AddDigits {
    public int _AddDigits(int num) {
        if(num==0)
            return 0;
        var k = num % 9 == 0 ? 9 : num % 9;
        return k;
    }
}