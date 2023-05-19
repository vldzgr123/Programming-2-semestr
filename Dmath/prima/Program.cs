
List<string> versini=new List<string>();
List<Grapg> rebra=new List<Grapg>();

Console.WriteLine("Введите вершины:");
versini.AddRange(Console.ReadLine().Split(" "));
Console.WriteLine("Введите ребра:");
StreamReader str=new StreamReader("1.txt");
while(true){
    Grapg s=new Grapg();
    string str1=str.ReadLine();
    if (str1=="0")
        break;
    string[] ans= str1.Split(" ");
    s.ver1=ans[0];
    s.ver2=ans[1];
    s.ves=Convert.ToInt32(ans[2]);
    rebra.Add(s);
}
str.Close();

string? put=rebra[0].ver1;
int dlina=0;
int dlinamin=0;
string? putmin="";
bool prov=false;
while(put.Length!=versini.Count){
    foreach(char p in put){
        foreach(Grapg r in rebra){
            if ((!r.ver1.Contains(p) && !r.ver2.Contains(p)) || (put.Contains(r.ver1) && put.Contains(r.ver2))){
                continue;
            }
            else{
                if (!prov){
                    dlinamin=r.ves;
                    if(put.Contains(r.ver1) && !put.Contains(r.ver2)){
                        putmin=r.ver2;
                    }
                    if(!put.Contains(r.ver1) && put.Contains(r.ver2)){
                        putmin=r.ver1;
                    }
                    prov=true;
                }
                if (r.ves<dlinamin){
                    if(put.Contains(r.ver1) && !put.Contains(r.ver2)){
                        putmin=r.ver2;
                        dlinamin=r.ves;
                    }
                    if(!put.Contains(r.ver1) && put.Contains(r.ver2)){
                        putmin=r.ver1;
                        dlinamin=r.ves;
                    }
                }
            }
        }
    }
    dlina+=dlinamin;
    put+=putmin;
    dlinamin=0;
    putmin="";
    prov=false;
    
}
Console.WriteLine($"Минимальный путь:{dlina}");



class Grapg{
    public string? ver1;
    public string? ver2;
    public int ves;
}
