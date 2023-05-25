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
double maxValueFlow=0;
while(true){
    var ids=new List<int>();
    double minFlow=double.PositiveInfinity;
    string peakNow=source;
    while(true){
        double maxPeak=0;
        int ribrId=0;
        for(int i=0;i<ribrs.Count();i++){
            if (peakNow==ribrs[i].peak1 && ribrs[i].weight!=0 && ribrs[i].check==true){
                if(maxPeak<ribrs[i].weight){
                    maxPeak=ribrs[i].weight;
                    ribrId=i;
                }
            }
        }
        minFlow=Math.Min(minFlow,maxPeak);
        peakNow=ribrs[ribrId].peak2;
        ids.Add(ribrId);
        if (peakNow==stock) break;
        if (!Check(peakNow,ribrs)) ribrs[ids[ids.Count()-1]].check=false;
        if(!Check(source,ribrs)) break;
    }
    if(!Check(source,ribrs)){
        break;
    }
    maxValueFlow+=minFlow;
    for(int i=0;i<ids.Count();i++){
        ribrs[ids[i]].weight-=minFlow;
        ribrs[ids[i]].weightOst+=minFlow;
    }
}
Console.WriteLine(maxValueFlow);


// while (true){
//     string tmp=source;
//     var ids=new List<int>();
//     double maxValue=double.PositiveInfinity;
//     while(true){
//         maxValue=double.PositiveInfinity;
//         ids.Clear();
//         tmp=source;
//         for (int i=0;i<ribrs.Count();i++){
//             if(ribrs[i].peak1==tmp && ribrs[i].weight!=0 && ribrs[i].check!=false){
//                 tmp=ribrs[i].peak2;
//                 maxValue=Math.Min(maxValue,ribrs[i].weight);
//                 ids.Add(i);
//             }
//             if (tmp==stock) break;
//         }
//         if(!Check(source,ribrs)) break;
//         if (tmp!=stock) ribrs[ids[ids.Count()-1]].check=false;
//         if(tmp==stock) break;
//     }
//     if (tmp!=stock) break;
//     maxValueFlow+=maxValue;
//     foreach(var id in ids){
//         ribrs[id].weight-=maxValue;
//     }
// }
Console.WriteLine(maxValueFlow);

static bool Check(string peak,List<Ribr> ribrs){
    foreach(var ribr in ribrs){
        if (ribr.peak1==peak && (ribr.check==true&&ribr.weight!=0)) return true;
    }
    return false;
}
