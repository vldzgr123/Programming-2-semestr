StreamReader streamReader = new StreamReader("input.txt");
var str1 = streamReader.ReadLine().Split("");
int N = Int32.Parse(str1[0]);
int M = Int32.Parse(str1[1]);
var str2 = streamReader.ReadLine().Split(" ");
int XN = Int32.Parse(str2[0]);
int YN = Int32.Parse(str2[1]);
int ZN = Int32.Parse(str2[2]);
for (int i = 0; i < M; i++)
{
    string[] strn = streamReader.ReadLine().Split(" ");
    string A = strn[0];
    int K = Int32.Parse(strn[1]);
    string S = strn[2];
    if (A == "X")
    {
    }
    if (A == "Y")
    {
    }
    if (A == "Z")
    {
        if (K == ZN)
        {
            if (S == "-1")
            {
                if (XN == 1 && YN == 1 || XN == N && YN == N)
                {
                    if (XN == 1 && YN == 1)
                    {
                        XN = N;
                        YN = 1;
                    }
                    else
                    {
                        XN = 1;
                        YN = N;
                    }
                    continue;
                }
                else
                {
                    if (XN == 1 || YN == 1)
                    {
                        if (XN == 1)
                        {
                            XN = YN;
                            YN = 1;
                        }
                        if (YN == 1)
                        {
                            YN = XN;
                            XN = N;
                        }
                    }
                    if (XN == N || YN = N)
                    {

                    }
                }
            }
            else
            {

            }
        }
        else continue;
    }
}
streamReader.Close();
Console.WriteLine(XN + " " + YN + " " + ZN);

