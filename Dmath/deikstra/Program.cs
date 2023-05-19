using deikstra;

var ribrs=new List<Ribr>();
var peaks=new List<Peak>();

var streamReader=new StreamReader("1.txt");

Console.WriteLine("Введите вершины:");//ввод вершин
while (true){
    string str=Console.ReadLine();
    if (str=="") break;
    var peak=new Peak();
    peak.name=str;
    peaks.Add(peak);
}

Console.WriteLine("Введите ребра:");//ввод ребер
while(true){
    string str=streamReader.ReadLine();
    if (str=="0") break;
    Ribr ribr=new Ribr();
    string peak1=str.Split(" ")[0];
    string peak2=str.Split(" ")[1];
    double weight=Convert.ToInt32(str.Split(" ")[2]);
    foreach(var peak in peaks){
        if (peak.name==peak1){
            ribr.peak1=peak;
        }
        if (peak.name==peak2){
            ribr.peak2=peak;
        }
    }
    ribr.weight=weight;
    ribrs.Add(ribr);
}

Console.WriteLine("Введите от какой веришины и до какой вершины нужно найти минимальный путь:");
string start=Console.ReadLine();
string finish=Console.ReadLine();

Peak tmpPeak=new Peak();

for(int i=0;i<peaks.Count;i++){
    if (i==0){//нахождение начальной вершины
        foreach(var peak in peaks){
            if (peak.name==start){
                peak.check=true;
                peak.weightMinimal=0;
                tmpPeak=peak;
                break;
            }
        }
    }
    else{
        foreach(var ribr in ribrs){//минимальный пути до каждой вершины
            if (ribr.peak1.name==tmpPeak.name || ribr.peak2.name==tmpPeak.name){
                if (ribr.peak1.name==tmpPeak.name){
                    ribr.peak2.weightMinimal=Math.Min(ribr.peak1.weightMinimal+ribr.weight,ribr.peak2.weightMinimal);
                }
                if (ribr.peak2.name==tmpPeak.name){
                    ribr.peak1.weightMinimal=Math.Min(ribr.peak2.weightMinimal+ribr.weight,ribr.peak1.weightMinimal);
                }
            }
        }
        double tmp=double.PositiveInfinity;
        int tmpid=0;
        for(int j=0;j<peaks.Count;j++){
            if (tmp>peaks[j].weightMinimal &&peaks[j].check==false){
                tmp=peaks[j].weightMinimal;
                tmpid=j;
            }
        }
        if (peaks[tmpid].name==finish){
            Console.WriteLine($"Кратчайший путь до вершины {start} - {peaks[tmpid].weightMinimal}");
            break;
        }
        peaks[tmpid].check=true;
        tmpPeak=peaks[tmpid];
    }
}
