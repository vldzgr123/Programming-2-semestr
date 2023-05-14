namespace fish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("1.txt");
            int count = Convert.ToInt32(streamReader.ReadLine());
            string[,] words = new string[count, 2];
            var start = new Dictionary<string, int>();
            var final = new Dictionary<string, int>();
            List<string> wordlist = new List<string>();
            for (int i = 0; i < count; i++)
            {
                wordlist.Add(streamReader.ReadLine());
            }
            wordlist.Sort();
            for (int i = 0; i < count; i++)
            {
                string word = wordlist[i];
                Char[] letters = word.ToCharArray();
                words[i, 0] = Convert.ToString(letters[0]);
                 words[i, 1] = Convert.ToString(letters[letters.Length - 1]);
            }
            int count1 = Convert.ToInt32(streamReader.ReadLine());
            for (int i = 0; i < count1; i++)
            {
                string perm = streamReader.ReadLine();
                string[] info = perm.Split(" ");
                start.Add(info[0], Convert.ToInt32(info[1]));
            }
            count1 = Convert.ToInt32(streamReader.ReadLine());
            for (int i = 0; i < count1; i++)
            {
                string perm = streamReader.ReadLine();
                string[] info = perm.Split(" ");
                final.Add(info[0], Convert.ToInt32(info[1]));
            }
            int sum = 0;
            streamReader.Close();
            for (int i = 0; i < count; i++)
            {
                if ((start.Keys.Contains(words[i, 0])) && (final.Keys.Contains(words[i, 1])))
                    if ((start[words[i, 0]] > 0) && (final[words[i, 1]] > 0))
                    {
                        sum++;
                        start[words[i, 0]] = start[words[i, 0]] - 1;
                        final[words[i, 1]] = final[words[i, 1]] - 1;
                    }
            }
            Console.WriteLine(sum);
        }
    }
}