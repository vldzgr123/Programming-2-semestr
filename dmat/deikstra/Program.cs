
List<versh> vershini=new List<versh>();
List<smeg> rebra=new List<smeg>();

Console.WriteLine("Введите вершины:");
while(true){

    string str=Console.ReadLine();
    if (str=="")
        break;
    versh s=new versh();
    s.name=str;
    vershini.Add(s);
}
Console.WriteLine("Введите ребра:");
StreamReader str2=new StreamReader("1.txt");
while(true){
    smeg s=new smeg();
    string? str1=str2.ReadLine();
    if (str1=="0") break;
    string[] ans= str1.Split(" ");
    s.ver1=ans[0];
    s.ver2=ans[1];
    s.ves=Convert.ToDouble(ans[2]);
    rebra.Add(s);
}
str2.Close();
string ver="";
Console.WriteLine("Введите от какой вершины:");
string ot=Console.ReadLine();
Console.WriteLine("Введите до какой вершины");
string to=Console.ReadLine();
Algorithm(rebra,vershini,ot,to);

static void Algorithm(List<smeg> rebra, List<versh> vershini, string ot, string to){
    versh tmp=new versh();
    tmp.name=ot;
    tmp.minput=double.PositiveInfinity;
    for(int i=0;i<rebra.Count;i++) {
        foreach (versh vershina in vershini){
            if (vershina.name==ot){
                vershina.check=false;
                continue;
            }
            if (vershina.check==false){
                foreach (smeg rebro in rebra){
                    if(rebro.ver1.Contains(vershina.name) && rebro.ver2.Contains(tmp.name) || rebro.ver1.Contains(tmp.name) && rebro.ver2.Contains(vershina.name)){
                        if (rebro.ves<vershina.minput){
                            vershina.minput=rebro.ves;
                        }
                        if (vershina.minput<tmp.minput){
                            tmp.minput=vershina.minput;
                            tmp.name=vershina.name;
                        }
                    }
                }
                foreach (var c in vershini)
                {
                    if (tmp.name==c.name) c.check=false;
                }
            }
        }
    }
    foreach(versh vers in vershini){
        if (vers.name==to) Console.WriteLine(vers.minput);
    }
    Console.WriteLine(vershini);
}
class smeg
{
    public string ver1;
    public string ver2;
    public double ves;
}
class versh
{
    public string name;
    public double minput=double.PositiveInfinity;
    public bool check=false;
}
