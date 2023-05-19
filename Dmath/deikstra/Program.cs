List<Rebro> rebra=new List<Rebro>();
string vershini="";
int count=0;
while(true){
    string reb1=Console.ReadLine();
    string[] reb=reb1.Split(" ");
    var rebro=new Rebro();
    if (reb1=="") break;
    if (!vershini.Contains(reb[0])) vershini+=reb[0];
    if (!vershini.Contains(reb[1])) vershini+=reb[1];
    rebro.ver1=reb[0];
    rebro.ver2=reb[1];
    rebro.ves=Convert.ToInt32(reb[2]);
    count=Math.Max(count,Convert.ToInt32(reb[2]));
    rebra.Add(rebro);
}
var valuever=new int[vershini.Length]; 
for (int i = 0; i < valuever.Length; i++)
{
    valuever[i]=1*count;
}
int ot=Convert.ToInt32(Console.ReadLine())-1;
int too=Convert.ToInt32(Console.ReadLine())-1;
string start=Convert.ToString(ot+1);
for (int i=0;i<valuever.Length;i++){
    for(int j=0;j<rebra.Count;j++){
        if(rebra[j].ver1==Convert.ToString(ot+1) && rebra[j].ver2==Convert.ToString(i+1)){
            valuever[i]=rebra[j].ves;
        }
    }
}
int minimumValue=count;
int minVer=0;
for (int i=0;i<valuever.Length;i++){
    if (valuever[i]<minimumValue && !start.Contains(Convert.ToString(i+1))){
        minimumValue=valuever[i];
        minVer=i;
    }
}
ot=minVer;
while (ot!=0){
    start+=Convert.ToString(ot+1);
    for(int i=0;i<valuever.Length;i++){
        for(int j=0;j<rebra.Count;j++){
            if(rebra[j].ver1==Convert.ToString(ot+1) &&rebra[j].ver2==Convert.ToString(i+1)){
                valuever[i]=Math.Min(rebra[j].ves+valuever[ot],valuever[i]);
            }
        }
    }
    minimumValue=count;
    minVer=0;
    for (int i=0;i<valuever.Length;i++){
        if(valuever[i]<minimumValue && !start.Contains(Convert.ToString(i+1))){
            minimumValue=valuever[i];
            minVer=i;
        }
    }
    ot=minVer;
}
Console.WriteLine(valuever[too]);
class Rebro{
    public string ver1;
    public string ver2;
    public int ves;
}