StreamReader input = new StreamReader("input.txt");
var str1 = input.ReadLine().Split(" ");
int N = Int32.Parse(str1[0]);
int M = Int32.Parse(str1[1]);
var str2 = input.ReadLine().Split(" ");
int XN = Int32.Parse(str2[0]);
int YN = Int32.Parse(str2[1]);
int ZN = Int32.Parse(str2[2]);
for (int i = 0; i < M; i++)
{
    string[] strn = input.ReadLine().Split(" ");
    string A = strn[0];
    int K = Int32.Parse(strn[1]);
    string S = strn[2];
    ChangePosition(A, K, S);
}
input.Close();
var output = new StreamWriter("output.txt");
output.WriteLine(XN + " " + YN + " " + ZN);
output.Close();

void ChangePosition(string A, int K, string S)
{
    if (Check(XN, YN, ZN, A, K))
    {
        if (S == "1")
        {
            if (A == "X")
            {
                int bZN = ZN;
                ZN = N - YN + 1;
                YN = bZN;
            }
            if (A == "Y")
            {
                int bZN = ZN;
                ZN = N - XN + 1;
                XN = bZN;
            }
            if (A == "Z")
            {
                int bYN = YN;
                YN = N - XN + 1;
                XN = bYN;
            }
        }
        else
        {
            if (A == "X")
            {
                int bYN = YN;
                YN = N - ZN + 1;
                ZN = bYN;
            }
            if (A == "Y")
            {
                int bXN = XN;
                XN = N - ZN + 1;
                ZN = bXN;
            }
            if (A == "Z")
            {
                int bXN = XN;
                XN = N - YN + 1;
                YN = bXN;
            }
        }
    }
}

bool Check(int XN, int YN, int ZN, string A, int K)
{
    if (A == "X" && XN == K)
    {
        return true;
    }
    if (A == "Y" && YN == K)
    {
        return true;
    }
    if (A == "Z" && ZN == K)
    {
        return true;
    }
    return false;
}