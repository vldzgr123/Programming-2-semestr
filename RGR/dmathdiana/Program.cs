
using System;
using System.Collections.Generic;

class Program {

        static void Main(string[] args) {
        // считывание данных
        StreamReader streamReader=new StreamReader("1.txt");
        string[] input = streamReader.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        char[][] maze = new char[n][];
        for (int i = 0; i < n; i++) {
            maze[i] = streamReader.ReadLine().ToCharArray();
        }
        streamReader.Close();

        // поиск начальной и конечной клеток
        int startRow = -1, startCol = -1, endRow = -1, endCol = -1;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (maze[i][j] == 'S') {
                    startRow = i;
                    startCol = j;
                } else if (maze[i][j] == 'F') {
                    endRow = i;
                    endCol = j;
                }
            }
        }

        // функция для проверки, находится ли клетка на расстоянии более одной клетки от Минотавра
        bool IsSafe(int row, int col) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (maze[i][j] == 'M' && Math.Abs(i-row) + Math.Abs(j-col) <= 1) {
                        return false;
                    }
                }
            }
            return true;
        }

        // BFS для поиска кратчайшего пути
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int[][] distances = new int[n][];
        for (int i = 0; i < n; i++) {
            distances[i] = new int[m];
            for (int j = 0; j < m; j++) {
                distances[i][j] = -1;
            }
        }
        queue.Enqueue((startRow, startCol));
        distances[startRow][startCol] = 0;
        while (queue.Count > 0) {
            (int row, int col) = queue.Dequeue();
            if (row == endRow && col == endCol) {
                Console.WriteLine(distances[row][col]);
                return;
            }
            foreach ((int drow, int dcol) in new[] {(0, 1), (0, -1), (1, 0), (-1, 0)}) {
                int newRow = row+drow;
                int newCol = col+dcol;
                if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < m && maze[newRow][newCol] != 'X' && IsSafe(newRow, newCol) && distances[newRow][newCol] == -1) {
                    distances[newRow][newCol] = distances[row][col] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }
        }
        Console.WriteLine("No path found");
    }
}

class Place{
    public int x;
    public int y;
}