﻿List<string> methods = new List<string>();
StreamReader streamReader = new StreamReader("input.txt");
string str = "";
while (!streamReader.EndOfStream)
{
    methods.Add(streamReader.ReadLine());

}
streamReader.Close();
List<string> chMethods = new List<string>();

foreach (string i in methods)
{

    str = "";
    if (i.Split()[0] == "DUST")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {
                str += chMethods[Convert.ToInt32(j) - 1];
            }
            else
            {
                str += j;
            }
        }
        chMethods.Add($"DT{str}TD");
    }
    else if (i.Split()[0] == "MIX")
    {
        string[] subStr = i.Split();
        subStr = subStr.Skip(1).ToArray();
        foreach (string j in subStr)
        {
            if (int.TryParse(j, out int number))
            {
                str += chMethods[Convert.ToInt32(j) - 1];
            }
            else
            {
                str += j;
            }
        }
        chMethods.Add($"MX{str}XM");
    }
    else if (i.Split()[0] == "WATER")
    {
        string[] substr = i.Split();
        substr = substr.Skip(1).ToArray();
        foreach (string j in substr)
        {
            if (int.TryParse(j, out int number))
            {

                str += chMethods[Convert.ToInt32(j) - 1];
            }
            else
            {
                str += j;
            }
        }
        chMethods.Add($"WT{str}TW");
    }
    else if (i.Split()[0] == "FIRE")
    {
        string[] subStr = i.Split();
        subStr = subStr.Skip(1).ToArray();
        foreach (string j in subStr)
        {
            if (int.TryParse(j, out int number))
            {
                str += chMethods[Convert.ToInt32(j) - 1];
            }
            else
            {
                str += j;
            }
        }
        chMethods.Add($"FR{str}RF");
    }

}
Console.WriteLine(chMethods[chMethods.Count - 1]);