﻿string[] w1 = Console.ReadLine().Split();
string[] w2 = new string[w1.Length];

w2[0] = w1[w1.Length / 2];
for (int i = 1; i <= w1.Length / 2; i++)
{
    w2[i * 2 - 1] = w1[w1.Length / 2 - i];
    if (w1.Length / 2 + i < w1.Length)
    {
        w2[i * 2] = w1[w1.Length / 2 + i];
    }
}

for (int i = 0; i < w2.Length; i++)
{
    string word = w2[i];
    string nowWord = "";
    nowWord += word[word.Length / 2];
    for (int j = 1; j <= word.Length / 2; j++)
    {
        nowWord += word[word.Length / 2 - j];
        if (word.Length / 2 + j < word.Length)
            nowWord += word[word.Length / 2 + j];
    }
    w2[i] = nowWord;
}

foreach (string i in w2)
{
    Console.Write(i + " ");
}