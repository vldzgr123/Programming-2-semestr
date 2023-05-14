using System.Runtime.InteropServices;

namespace kubikrubika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string file = "1.txt";
            StreamReader streamReader = new StreamReader(file);

            int[][] mass = new int[2][];

            for (int i = 0; i < 2; i++)
            {
                mass[i] = Array.ConvertAll(streamReader.ReadLine().Split(' ', '\n').ToArray(), int.Parse);
            }

            int size = mass[0][0];
            int k = mass[0][1];

            int startX = mass[1][0];
            int startY = mass[1][1];
            int startZ = mass[1][2];


            int[][] povorot = new int[k][];

            for (int i = 0; i < k; i++)
            {
                string str = streamReader.ReadLine();
                if (str[0] == 'Z')
                {
                    str = str.Replace('Z', '3');
                }
                else if (str[0] == 'Y')
                {
                    str = str.Replace('Y', '2');
                }
                else if (str[0] == 'X')
                {
                    str = str.Replace('X', '1');
                }
                povorot[i] = Array.ConvertAll(str.Split(' ', '\n').ToArray(), int.Parse);
            }
            Console.WriteLine($"{startX} {startY} {startZ}");
            streamReader.Close();
            for (int i = 0; i < k; i++)
            {
                if (povorot[i][0] == 1 && povorot[i][1] == startX)
                {
                    if (povorot[i][2] == -1)
                    {
                        int a = 0;
                        for (int j = size; j > 0; j--, a++)
                            if (startY == j)
                                break;
                        int b = 0;
                        for (int j = size; j > 0; j--, b++)
                            if (startZ == j)
                                break;
                        startY = 1 + b;
                        startZ = (size) - a;
                    }
                    else if (povorot[i][2] == 1)
                    {
                        int a = 0;
                        for (int j = 1; j <= size; j++, a++)
                            if (startY == i)
                                break;
                        int b = 0;
                        for (int j = 1; j <= size; j++, b++)
                            if (startZ == j)
                                break;
                        startY = 1 + b;
                        startZ = (size) - a;
                    }
                }
                else if (povorot[i][0] == 2 && povorot[i][1] == startY) 
                {
                    if (povorot[i][2] == -1)
                    {
                        int a = 0;
                        for (int j = size; j > 0; j--, a++)
                            if (startX == j)
                                break;
                        int b = 0;
                        for (int j = size; j > 0; j--, b++)
                            if (startZ == j)
                                break;
                        startX = 1 + b;
                        startZ = (size) - a;
                    }
                    else if (povorot[i][2] == 1)
                    {
                        int a = 0;
                        for (int j = 1; j <= size; j++, a++)
                            if (startX == j)
                                break;
                        int b = 0;
                        for (int j = 1; j <= size; j++, b++)
                            if (startZ == j)
                                break;
                        startX = 1 + b;
                        startZ = (size) - a;
                    }
                }
                else if (povorot[i][0] == 3 && povorot[i][1] == startZ)
                {
                    if (povorot[i][2] == -1)
                    {
                        int a = 0;
                        for (int j = size; j > 0; j--, a++)
                            if (startX == j)
                                break;
                        int b = 0;
                        for (int j = size; j > 0; j--, b++)
                            if (startY == j)
                                break;
                        startX = 1 + b;
                        startY = (size) - a;
                    }
                    else if (povorot[i][2] == 1)
                    {
                        int a = 0;
                        for (int j = 1; j <= size; j++, a++)
                            if (startX == j)
                                break;
                        int b = 0;
                        for (int j = 1; j <= size; j++, b++)
                            if (startY == j)
                                break;
                        startX = 1 + b;
                        startY = (size) - a;
                    }
                }
            }
            Console.WriteLine($"{startX} {startY} {startZ}");
        }
    }
}