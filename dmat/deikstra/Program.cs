
List<versh> vershini=new List<versh>();
List<smeg> rebra=new List<smeg>();
string vers="";
Console.WriteLine("Введите вершины:");
while(true){
    versh ver=new versh();
    ver.name=Console.ReadLine();
    if (ver.name=="") break;
    vershini.Add(ver);
}
Console.WriteLine("Введите ребра:");
StreamReader str2=new StreamReader("1.txt");
while(true){
    smeg s=new smeg();
    string? str1=str2.ReadLine();
    if (str1=="0") break;
    string[] ans= str1.Split(" ");
    string ver1=ans[0];
    string ver2=ans[1];
    if (!vers.Contains(ver1)||!vers.Contains(ver2)){
        if(!vers.Contains(ver2)&&!vers.Contains(ver1)){
            foreach(versh i in vershini){
                if (i.name==ver2){
                    s.ver2=i;
                    vers+=i.name;
                }
                if (i.name==ver1){
                    s.ver1=i;
                    vers+=i.name;
                }
            }
        }
        if(!vers.Contains(ver1)&&vers.Contains(ver2)){
            foreach(versh i in vershini){
                if (i.name==ver1){
                    s.ver1=i;
                    vers+=i.name;
                    break;
                }
            }
        }
        if(!vers.Contains(ver2)&&vers.Contains(ver1)){
            foreach(versh i in vershini){
                if (i.name==ver2){
                    s.ver2=i;
                    vers+=i.name;
                    break;
                }
            }
        }
    }
    s.ves=Convert.ToDouble(ans[2]);
    rebra.Add(s);
}
str2.Close();
Console.WriteLine("Введите от какой вершины:");
string ot=Console.ReadLine();
Console.WriteLine("Введите до какой вершины");
string to=Console.ReadLine();
Algorithm(rebra,vershini,ot,to);

static void Algorithm(List<smeg> rebra, List<versh> vershini, string ot, string to){
    int toid=0;
    double put=0;
    for(int i=0;i<vershini.Count;i++)
    {
        if(i==0){
            for(int k=0;k<vershini.Count;k++){
                if (vershini[k].name==ot){
                    vershini[k].minput=0;
                    vershini[k].check=true;
                }
                if (vershini[k].name==to){
                    toid=k;
                }
            }
        }
        else{
            for(int k=0;k<rebra.Count;k++){
                if (ot.Contains(rebra[k].ver1.name) || ot.Contains(rebra[k].ver2.name)){
                    if(ot.Contains(rebra[k].ver1.name)){
                        if (rebra[k].ver2.check==false) rebra[k].ver2.minput=Math.Min(rebra[k].ver2.minput,rebra[k].ves+rebra[k].ver1.minput);
                    }
                    else{
                        if (rebra[k].ver2.check==false) rebra[k].ver1.minput=Math.Min(rebra[k].ver1.minput,rebra[k].ves+rebra[k].ver2.minput);
                    }
                }
            }
            double tmp=double.PositiveInfinity;
            int minid=0;
            for (int k=0;k<vershini.Count;k++){
                if (tmp>vershini[k].minput && vershini[k].check==false){
                    minid=k;
                    tmp=vershini[k].minput;
                }
            }
            if (vershini[minid].name==to){
                Console.WriteLine(vershini[minid].minput);
                break;
            }
            else{
                vershini[minid].check=true;
                ot=vershini[minid].name;
            }
        }
    }
}
class smeg
{
    public versh ver1;
    public versh ver2;
    public double ves;
}
class versh
{
    public string name;
    public double minput=double.PositiveInfinity;
    public bool check=false;
}
