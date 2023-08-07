var input = new StreamReader("input.txt");
var widthDepthHeight = input.ReadLine().Split(" ");
double a = Convert.ToDouble(widthDepthHeight[0]);
double b = Convert.ToDouble(widthDepthHeight[1]);
double c = Convert.ToDouble(widthDepthHeight[2]);
string[] coordinatesSpider = input.ReadLine().Split(" ");
double Sx = Convert.ToDouble(coordinatesSpider[0]);
double Sy = Convert.ToDouble(coordinatesSpider[1]);
double Sz = Convert.ToDouble(coordinatesSpider[2]);
string[] coordinatesFly = input.ReadLine().Split(" ");
double Fx = Convert.ToDouble(coordinatesFly[0]);
double Fy = Convert.ToDouble(coordinatesFly[1]);
double Fz = Convert.ToDouble(coordinatesFly[2]);
input.Close();
StreamWriter output=new StreamWriter("output.txt");
if (Sx == Fx && (Sx == a || Sx == 0) || Sy == Fy && (Sy == b || Sy == 0) || Sz == Fz && (Sz == c || Sz == 0))
{
    Console.WriteLine(sameWall());
}


double sameWall()
{
    return Math.Round(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Fz, 2)),3);
}
double relatedWalls()
{
    
}
