Console.WriteLine("Введите кол-во вершин:");
int n=Int32.Parse(Console.ReadLine());
double [,] matr=new double[n,n];
Console.WriteLine("Ввод элементов матрицы:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++){
        matr[i,j]=Int32.Parse(Console.ReadLine());
        if (matr[i,j]==0){
            matr[i,j]=double.PositiveInfinity;
        }
        if(i==j){
            matr[i,j]=0;
        }
    }
}
for (int k=0;k<n;k++){
    for (int i=0;i<n;i++){
        for (int j=0;j<n;j++){
            matr[i,j]=Math.Min(matr[i,k]+matr[k,j],matr[i,j]);
        }
    }
}
for (int i=0;i<n;i++){
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matr[i,j]}\t");
        
    }
    Console.WriteLine("");
}
