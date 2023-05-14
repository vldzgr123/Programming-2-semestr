using System;
using System.IO;
using spider;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            int[] y= new int[3];
            int[] z= new int[3];
            double final=0;
            StreamReader streamReader = new StreamReader("1.txt");
            for (int i = 0; i < 3; i++)
            {
                var line = streamReader.ReadLine().Split();
                x[i] = int.Parse(line[0]);
                y[i] = int.Parse(line[1]);
                z[i] = int.Parse(line[2]);
            }
            streamReader.Close();
            if (x[1] == 0 || x[1] == x[0])
                final = Movement.MotionTracking(y, x, z);
                
            else if (y[1] == 0 || y[1] == y[0])
                final = Movement.MotionTracking(x, y, z);
                
            else if (z[1] == 0 || z[1] == z[0])
                final = Movement.MotionTracking(y, z, x);

            StreamWriter streamWriter = new StreamWriter("2.txt");
            streamWriter.Write(Math.Round(final, 3));
            streamWriter.Close();
        }
    }
}