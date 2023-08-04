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
    ChangePositions(XN, YN, ZN, A, K, S);
}
streamReader.Close();
Console.WriteLine(XN + " " + YN + " " + ZN);

void ChangePositions()
{
    if Check(int XN, int YN, int ZN, string A, int K){
        if (S == "1")
        {

        }
        if (S == "-1")
        {

        }
    }
}

bool Check(int XN, int YN, int ZN, string A, int K)
{
    if (A = "X" && XN == K)
    {
        return true;
    }
    if (A = "Y" && YN == K)
    {
        return true;
    }
    if (A = "Z" && ZN == K)
    {
        return true;
    }
    return false;
}