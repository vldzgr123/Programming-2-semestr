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
StreamWriter output = new StreamWriter("output.txt");
if (Sx == Fx && (Sx == a || Sx == 0) || Sy == Fy && (Sy == b || Sy == 0) || Sz == Fz && (Sz == c || Sz == 0))
{
    output.WriteLine(sameWall());
}
else if ((Math.Abs(Sx - Fx) == a) || Math.Abs(Sy - Fy) == b || Math.Abs(Sz - Fz) == c)
{
    output.WriteLine(oppositeWalls());
}
else
{
    output.WriteLine(relatedWalls());
}
output.Close();
double sameWall()
{
    return Math.Round(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Fz, 2)), 3);
}
double relatedWalls()
{
    double minimumDistance;
    if (Sx == a || Sx == 0)
    {
        if (Fy == b || Fy == 0)
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(0 - Fy, 2) + Math.Pow(Sz - Fz, 2)) + Sy, Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(b - Fy, 2) + Math.Pow(Sz - Fz, 2)) + b - Sy);
        }
        else
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(0 - Fz, 2)) + Sz, Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(c - Fz, 2)) + c - Sz);
        }
    }
    else if (Sy == b || Sy == 0)
    {
        if (Fx == a || Fx == 0)
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(0 - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Fz, 2)) + Sx, Math.Sqrt(Math.Pow(a - Fx, 2) + Math.Pow(b - Fy, 2) + Math.Pow(Sz - Fz, 2)) + a - Sx);
        }
        else
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(0 - Fz, 2)) + Sz, Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(c - Fz, 2)) + c - Sz);
        }
    }
    else
    {
        if (Fx == a || Fx == 0)
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(0 - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Fz, 2)) + Sx, Math.Sqrt(Math.Pow(a - Fx, 2) + Math.Pow(b - Fy, 2) + Math.Pow(Sz - Fz, 2)) + a - Sx);
        }
        else
        {
            minimumDistance = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(0 - Fz, 2)) + Sz, Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2) + Math.Pow(c - Fz, 2)) + c - Sz);
        }
    }
    return Math.Round(minimumDistance, 3);
}
double oppositeWalls()
{
    double minimumDistance;
    double minimumDistanceX;
    double minimumDistanceY;
    double minimumDistanceZ;
    if (Math.Abs(Sx - Fx) == a)
    {
        minimumDistanceY = Math.Min(Math.Sqrt(Math.Pow((-(b - Sy) + Sx) - (b - Fy - Fx), 2) + Math.Pow(Sz - Fz, 2)), Math.Sqrt(Math.Pow(Sx - Sy - (Fx + Fy), 2) + Math.Pow(Sz - Fz, 2)));
        minimumDistanceZ = Math.Min(Math.Sqrt(Math.Pow((-(c - Sz) + Sx) - (Fx + (c - Fz)), 2) + Math.Pow(Sy - Fy, 2)), Math.Sqrt(Math.Pow(Sx + Sz - (Fx - Fz), 2) + Math.Pow(Sy - Fy, 2)));
        minimumDistance = Math.Min(minimumDistanceY, minimumDistanceZ);
    }
    else if (Math.Abs(Sy - Fy) == b)
    {
        minimumDistanceX = Math.Min(Math.Sqrt(Math.Pow((Sy - (a - Sx)) - (Fy + (a - Fx)), 2) + Math.Pow(Sz - Fz, 2)), Math.Sqrt(Math.Pow((Sy - Sx) - (Fy + Fx), 2) + Math.Pow(Sz - Fz, 2)));
        minimumDistanceZ = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Fy, 2)) + (c - Sz) + (c - Fz), Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sy - Sz - (Fy + Fz), 2)));
        minimumDistance = Math.Min(minimumDistanceX, minimumDistanceZ);
    }
    else
    {
        minimumDistanceX = Math.Min(Math.Sqrt(Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - (a - Sx) - (Fz + (a - Fx)), 2)), Math.Sqrt(Math.Pow(Sy - Fy, 2) + Math.Pow(Sz - Sx - (Fz + Fx), 2)));
        minimumDistanceY = Math.Min(Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sz - (b - Sy) - (Fz + (b - Fy)), 2)), Math.Sqrt(Math.Pow(Sx - Fx, 2) + Math.Pow(Sz - Sy - (Fz + Fy), 2)));
        minimumDistance = Math.Min(minimumDistanceY, minimumDistanceX);
    }
    return Math.Round(minimumDistance, 3);
}
