int[] nums = { 2, 5, 1, 3, 4, 7 };
int n = 3;
int[] numssss = new int[nums.Length];
for (int i = 0; i < n; i++)
{
    numssss[i*2] = nums.Take(n).ToArray()[i];
    numssss[i*2+1] = nums.TakeLast(n).ToArray()[i];

}
foreach (var item in numssss)
{
    Console.WriteLine(item);
}
    