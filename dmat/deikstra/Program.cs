
List<versh> versini=new List<versh>();
List<smeg> rebra=new List<smeg>();

Console.WriteLine("Введите вершины:");
while(true){

    string str=Console.ReadLine();
    if (str=="")
        break;
    versh s=new versh();
    s.name=str;
    rebra.Add(s);
}
Console.WriteLine("Введите ребра:");
while(true){
    smeg s=new smeg();
    string str1=Console.ReadLine();
    if (str1=="")
        break;
    string[] ans= str1.Split(" ");
    s.ver1=ans[0];
    s.ver2=ans[1];
    s.ves=Convert.ToInt32(ans[2]);
    rebra.Add(s);
}
string ver="";
Console.WriteLine("Введите от какой вершины старт:");
string ot=Console.ReadLine();
foreach(versh c in versini){
    if (c.name!=ot) c.minput=double.PositiveInfinity;
    else ver+=c;
}
for (int i = 1; i < versini.Count; i++)
{
    foreach(smeg rebro in rebra){
        if(rebro.ver1==ot || rebro.ver2==ot){
            if(rebro.ver1==ot && ver.Contains(rebro.ver2)
        }
    }
}

class smeg
{
    public string ver1;
    public string ver2;
    public int ves;
}
class versh
{
    public string name;
    public int minput=0;
}