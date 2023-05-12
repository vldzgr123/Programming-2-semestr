while (true){
    Console.WriteLine("1.Программа");
    Console.WriteLine("2.Об авторе");
    Console.WriteLine("3.Выход");
    int key=Convert.ToInt32(Console.ReadLine());
    if (key==3) break;
    switch(key){
        case 1:
            Console.Clear();
            Prog();
            Console.WriteLine("===============================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine($"Об авторе:\nЗагребельный Владислав Александрович, студент группы ФИТ-221.");
            Console.WriteLine("===============================");
            break;
    }
}
static void Prog(){
    StreamReader date=new StreamReader("1.txt");
    int n=Convert.ToInt32(date.ReadLine());
    int m=Convert.ToInt32(date.ReadLine());
    double[,] matrix= new double[n,n];
    for (int i=0;i<m;i++){
        string[] str=date.ReadLine().Split(" ");
        matrix[Convert.ToInt32(str[0])-1,Convert.ToInt32(str[1])-1]=Convert.ToDouble(str[2]);
        matrix[Convert.ToInt32(str[1])-1,Convert.ToInt32(str[0])-1]=Convert.ToDouble(str[2]);
    }
    date.Close();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++){
            if (matrix[i,j]==0){
                matrix[i,j]=double.PositiveInfinity;
            }
            if(i==j){
                matrix[i,j]=0;
            }
        }
    }
    for (int k=0;k<n;k++){
        for (int i=0;i<n;i++){
            for (int j=0;j<n;j++){
                matrix[i,j]=Math.Min(matrix[i,k]+matrix[k,j],matrix[i,j]);
            }
        }
    }
    Console.WriteLine("Кратчайшие пути:");
    for (int i = 0; i < n; i++)
    {
        for (int j=i+1; j<n;j++){
            if (matrix[i,j]==double.PositiveInfinity){
                Console.WriteLine($"{i+1} {j+1} -1");
            }
            else{
                Console.WriteLine($"{i+1} {j+1} {matrix[i,j]}");
            }
        }
    }
}