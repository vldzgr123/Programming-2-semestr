﻿List<string> workers = new List<string>();
StreamReader streamReader = new StreamReader("input.txt");
string pers = "";
List<string> straight = new List<string>();
List<string> final = new List<string>();
bool check = false;
while (!streamReader.EndOfStream)
{
    string s = streamReader.ReadLine();
    if (s != "END" && !check)
    {
        workers.Add(s);
    }
    if (s == "END")
    {
        check = true;
        pers = streamReader.ReadLine();
    }

}
streamReader.Close();
if (pers.Length >= 4)
{
    foreach (string i in workers)
    {
        if (i.Split().Length >= 2 && i.Remove(0, 5) == pers)
            pers = i.Split()[0];

    }
}
for (int i = 0; i < workers.Count; i = i + 2)
{
    if (workers[i].Split()[0] == pers.Split()[0])
    {
        straight.Add((workers[i + 1]));
        final.Add((workers[i + 1]));
        var a = findPersonal(straight);
    }
}
for (int i = 0; i < final.Count; i++)
{

    foreach (string j in workers)
    {
        if (j.Split().Length >= 2 && j.Split()[0] == final[i].Split()[0])
        {

            final[i] = j;
        }
    }

}
foreach (string i in final)
{
    if (i.Split().Length >= 2)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine($"{i} Unknown Name");

    }
}
List<string> findPersonal(List<string> star)
{
    List<string> link = new List<string>();
    for (int k = 0; k < star.Count; k++)
    {
        for (int i = 0; i < workers.Count; i = i + 2)
        {
            if (workers[i].Split()[0] == star[k].Split()[0])
            {
                link.Add(workers[i + 1]);
                final.Add((workers[i + 1]));
            }
        }
    }
    if (star.Count != 1 && link.Count != 0)
    {
        return findPersonal(link);
    }
    else
    {
        return link;
    }
}