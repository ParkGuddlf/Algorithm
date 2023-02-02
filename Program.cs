// // See https://aka.ms/new-console-template for more information
var words = new string[] { "word","world","row" };
var order = "worldabcefghijkmnpqstuvxyz";

Dictionary<char, int> dic = new Dictionary<char, int>();

for (int i = 0; i < order.Length; i++)
{
    dic.Add(order[i], i);
}

for (int i = 0; i < words.Length - 1; i++)
{
    var firstWord = words[i];
    var secondWord = words[i + 1];
    for (int j = 0; j < Math.Min(firstWord.Count(), secondWord.Count()); j++)
    {
        if (j == Math.Min(firstWord.Count(), secondWord.Count())-1 && firstWord.Count() < secondWord.Count())
            Console.WriteLine("as");
        if (dic[firstWord.ElementAt(j)] < dic[secondWord.ElementAt(j)])
            break;
        else if (dic[firstWord.ElementAt(j)] > dic[secondWord.ElementAt(j)])
            Console.WriteLine("f");

    }
    Console.WriteLine("t");
}