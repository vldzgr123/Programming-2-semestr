namespace kraskal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<smeg> smegs = zapol();
            put puti = new put();
            bool c = false;
            bool b = false;

            for (int i = 0; i < smegs.Count; i++)
            {
                if (i == 0)
                {
                    puti.puti += smegs[i].ves;
                    puti.verhini.Add(smegs[i].ver1 + smegs[i].ver2);
                    continue;
                }
                for (int j = 0; j < puti.verhini.Count; j++)
                {
                    if (puti.verhini[j].Contains(smegs[i].ver1) && puti.verhini[j].Contains(smegs[i].ver2))
                    {
                        c = true;
                        break;
                    }
                }
                if (c == false)
                {
                    if (puti.verhini.Count > 1)
                    {
                        for (int j = 0; j < puti.verhini.Count; j++)
                        {
                            for (int k = 0; k < puti.verhini.Count; k++)
                            {
                                if (k == j)
                                {
                                    continue;
                                }
                                if ((puti.verhini[j].Contains(smegs[i].ver1) == true && puti.verhini[k].Contains(smegs[i].ver1) == false) && (puti.verhini[k].Contains(smegs[i].ver2) == true && puti.verhini[j].Contains(smegs[i].ver2) == false) || (puti.verhini[j].Contains(smegs[i].ver1) == false && puti.verhini[k].Contains(smegs[i].ver1) == true) && (puti.verhini[j].Contains(smegs[i].ver2) == true && puti.verhini[k].Contains(smegs[i].ver2) == false))
                                {
                                    puti.verhini[j] += puti.verhini[k];
                                    puti.verhini.RemoveAt(k);
                                    puti.puti += smegs[i].ves;
                                    b = true;                                    break;
                                }
                            }
                            if (b)
                            {
                                break;
                            }
                        }
                    }
                    if (b == false)
                    {
                        for (int j = 0; j < puti.verhini.Count; j++)
                        {
                            if (puti.verhini[j].Contains(smegs[i].ver1) == true && puti.verhini[j].Contains(smegs[i].ver2) == false)
                            {
                                puti.verhini[j] += smegs[i].ver2;
                                puti.puti += smegs[i].ves;
                                break;

                            }
                            if (puti.verhini[j].Contains(smegs[i].ver1) == false && puti.verhini[j].Contains(smegs[i].ver2) == true)
                            {
                                puti.verhini[j] += smegs[i].ver1;
                                puti.puti += smegs[i].ves;
                                break;
                            }

                            else
                            {
                                puti.puti += smegs[i].ves;
                                puti.verhini.Add(smegs[i].ver1 + smegs[i].ver2);
                                break;
                            }
                        }
                    }
                }
                c = false;
                b = false;
            }
            Console.WriteLine(puti.puti);
        }
        static List<smeg> zapol()
        {
            Console.WriteLine("Вершины вес(чтобы закончить - пустая строка)");
            List<smeg> smegs=new List<smeg>();
            while (true)
            {
                smeg sm = new smeg();
                string? str=Console.ReadLine();
                if (str == "")
                {
                    break;
                }
                string[] arr = str.Split(" ");
                sm.ver1 = arr[0];
                sm.ver2 = arr[1];
                sm.ves = Convert.ToInt32(arr[2]);
                smegs.Add(sm);
            }
            for (int k = 0; k < smegs.Count - 1; k++)
            {
                for (int i = 0; i < smegs.Count - 1; i++)
                {
                    if (smegs[i].ves > smegs[i + 1].ves)
                    {
                        var tmp = smegs[i];
                        smegs[i] = smegs[i + 1];
                        smegs[i + 1] = tmp;
                    }
                }
            }
            return smegs;

        }


    }
    class smeg
    {
        public string ver1;
        public string ver2;
        public int ves;
    }
    class put
    {
        public int puti=0;
        public List<string> verhini = new List<string>();
    }
}