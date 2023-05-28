using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int absmin = 0;
            int[,] matrix = { { -1, 6, 2, 8, 7 },
                              { 6, -1, 7, 13, 1 },
                              { 2, 7, -1, 4, 3 },
                              { 8, 13, 4, -1, 5 },
                              { 7, 1, 3, 5, -1 } };

            for (int p = 0; p < matrix.GetLength(0) - 1; p++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int min = int.MaxValue;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < min && matrix[i, j] >= 0)
                        {
                            min = matrix[i, j];

                        }

                    }
                    if (min == int.MaxValue)
                    {
                        min = 0;
                    }
                    absmin += min;
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[i, j] >= 0)
                        {
                            matrix[i, j] -= min;
                        }

                    }

                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(absmin);

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int min = int.MaxValue;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[j, i] < min && matrix[j, i] >= 0)
                        {
                            min = matrix[j, i];

                        }

                    }
                    if (min == int.MaxValue)
                    {
                        min = 0;
                    }
                    absmin += min;
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[j, i] >= 0)
                        {
                            matrix[j, i] -= min;
                        }

                    }

                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(absmin);
                int nulmax = -999;
                int stolbj = 0;
                int stolbi = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            int minnulsum1 = int.MaxValue;
                            int minnulsum2 = int.MaxValue;
                            for (int k = 0; k < matrix.GetLength(0); k++)
                            {
                                if (k != j)
                                {
                                    if (matrix[i, k] < minnulsum1 && matrix[i, k] >= 0)
                                    {
                                        minnulsum1 = matrix[i, k];
                                    }
                                }
                            }
                            for (int l = 0; l < matrix.GetLength(1); l++)
                            {
                                if (l != i)
                                {
                                    if (matrix[l, j] < minnulsum2 && matrix[l, j] >= 0)
                                    {
                                        minnulsum2 = matrix[l, j];
                                    }
                                }
                            }
                            if (minnulsum1 + minnulsum2 > nulmax)
                            {
                                nulmax = minnulsum1 + minnulsum2;
                                stolbi = i;
                                stolbj = j;
                            }
                            Console.WriteLine(nulmax + " " + stolbi + " " + stolbj);
                        }
                    }
                }
                matrix[stolbj, stolbi] = -1;
                int index = 0;
                if (p > 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(0); j++)
                        {
                            if (matrix[i, j] != -1)
                            {
                                matrix[i, j] = -1;
                                index = j;
                                break;
                            }
                                

                        }
                        if (matrix[i,index] == 0)
                        {
                            break;
                        }
                        
                    }
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[stolbi, i] = -1;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, stolbj] = -1;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(absmin);
            }
            int ffs = int.MaxValue;
        }

    }
}