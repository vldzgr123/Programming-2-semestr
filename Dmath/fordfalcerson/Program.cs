using fordfalcerson;

var ribrs=new List<Ribr>();
var ribrsOst=new List<Ribr>();
string peaks="";

Console.WriteLine("Введите ребра:");
StreamReader streamReader=new StreamReader("1.txt");
while(true){
    Ribr ribr=new Ribr();
    string str=streamReader.ReadLine();
    if (str=="0")
        break;
    string[] ans= str.Split(" ");
    ribr.peak1=ans[0];
    if (!peaks.Contains(ans[0])) peaks+=ans[0];
    if (!peaks.Contains(ans[1])) peaks+=ans[1];
    ribr.peak2=ans[1];
    ribr.weight=Convert.ToDouble(ans[2]);
    ribrs.Add(ribr);
}
streamReader.Close();

string? stock=null;
string? source=null;

foreach(var peak in peaks){
    bool stockCheck=false;
    bool sourceCheck=false;
    foreach(var ribr in ribrs){
        if (ribr.peak1==Convert.ToString(peak)) sourceCheck=true;
        if (ribr.peak2==Convert.ToString(peak)) stockCheck=true;
    }
    if (sourceCheck==true && stockCheck==false) source=Convert.ToString(peak);
    if (sourceCheck==false && stockCheck==true) stock=Convert.ToString(peak);
}


double maxAllFlow=0;
while(true){
    var ribrsId = new Dictionary<int,int>();
    double minFlow=double.PositiveInfinity;
    string peakNow=source;
    if (checkSource(source,ribrs)){
        while(peakNow!=stock){
            var idsBack=new List<int>();
            int direction=0;
            double maxWeight=0;
            int id=-10;
            for(int i=0;i<ribrs.Count();i++){
                if (ribrs[i].peak1==peakNow && ribrs[i].weight>0 && !idsBack.Contains(i)){
                    if(maxWeight<ribrs[i].weight){
                        id=i;
                        maxWeight=ribrs[i].weight;
                        direction=1;
                    }
                }
                else if (ribrs[i].peak2==peakNow && ribrs[i].weight==0 && !idsBack.Contains(i) && Check(ribrs[i].peak2,ribrs,stock)){
                    if(maxWeight<ribrs[i].weight){
                        id=i;
                        maxWeight=ribrs[i].weight;
                        direction=-1;
                    }
                }
            }
            if (id==-10){
                break;
            }
            if(direction==1){
                peakNow=ribrs[id].peak2;
            }
            if(direction==-1){
                peakNow=ribrs[id].peak1;
            }
            if (!Check(peakNow,ribrs,stock)){
                idsBack.Add(id);
                if(direction==1){
                    peakNow=ribrs[id].peak1;
                }
                if(direction==-1){
                    peakNow=ribrs[id].peak2;
                }
                continue;
            }
            minFlow=Math.Min(minFlow,maxWeight);
            ribrsId.Add(id,direction);
        }
        foreach(var ribrId in ribrsId){
            if (ribrId.Value==1){
                ribrs[ribrId.Key].weight-=minFlow;
                ribrs[ribrId.Key].weightOst+=minFlow;
            }
            if (ribrId.Value==-1){
                ribrs[ribrId.Key].weight+=minFlow;
                ribrs[ribrId.Key].weightOst-=minFlow;
            }
        }
        maxAllFlow+=minFlow;
    }
    else{
        break;
    }
}
Console.WriteLine(maxAllFlow);

static bool Check(string peak,List<Ribr> ribrs,string stock){
    foreach(var ribr in ribrs){
        if (ribr.peak1==peak && ribr.weight!=0) return true;
        if (ribr.peak2==peak && ribr.weightOst!=0) return true;
        if (ribr.peak2==stock) return true;
    }
    return false;
}
static bool checkSource(string source,List<Ribr> ribrs){
    foreach(var ribr in ribrs){
        if (ribr.peak1==source && ribr.weight!=0 ) return true; 
    }
    return false;
}
