/*숫자가 높은지 낮은지 추측하기
우리는 추측 게임을 하고 있습니다. 게임은 다음과 같습니다.

제가 1에서 n까지의 숫자 중 하나를 선택합니다. 당신은 제가 선택한 숫자를 추측해야 합니다.

당신이 틀릴 때마다 내가 선택한 숫자가 당신의 추측보다 높은지 낮은지 알려줄 것입니다.

-1: 당신의 추측이 제가 선택한 숫자보다 높습니다(즉, num > pick).
1: 당신의 추측이 제가 선택한 숫자보다 낮습니다(즉, num < pick).
0: 당신의 추측이 제가 선택한 숫자와 같습니다(즉, num == pick).
제가 선택한 번호를 반환합니다.*/
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
using System;

public class GNHL
{
    public static int GuessNumberHigherorLower(int n)
    {
        var i = 1;
        var j = n;
        while (i <= j)
        {
            int mid = i + (j - i) / 2;
            if (guess(mid) > 0)
                i = mid + 1;
            else if (guess(mid) < 0)
                j = mid - 1;
            else
                return mid;
        }
        return -1;
    }
    static int guess(int n)
    {
        return 0;
    }
}