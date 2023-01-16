// // See https://aka.ms/new-console-template for more information
string[] strs = new string[] { "cba", "daf", "ghi" };

int deletArrayCount = 0;
for (int i = 0; i < strs[0].Length; i++)
{
    var asd = strs.Select(n=>n[i]);
    if (!Enumerable.SequenceEqual(asd, asd.OrderBy(n => n)))
        deletArrayCount++;

}
Console.WriteLine(deletArrayCount);
