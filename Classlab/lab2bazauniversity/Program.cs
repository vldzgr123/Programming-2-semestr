namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> studenti=zapolstudent();
            List<prepod> prepodi=zapolprepod();
            List<upr> upri=zapolupr();
            List<spec> speci=zapolspec();
            int n = 0;
            do
            {
                mainmenu();
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 5 || n >= 1)
                {
                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            viborkastudsdolg(studenti);
                            break;
                        case 2:
                            Console.Clear();
                            viborkaprepsdolg(studenti);
                            break;
                        case 3:
                            Console.Clear();
                            vivorkaprikaz(upri);
                            break;
                        case 4:
                            Console.Clear();
                            viborkastag(prepodi);
                            break;
                        case 5:
                        
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }

            }
            while (n != 5);
        }
        static void mainmenu()
        {
            Console.WriteLine("Выборки:");
            Console.WriteLine("1.Студенты с долгами");
            Console.WriteLine("2.Преподаватели с долгами");
            Console.WriteLine("3.Приказы");
            Console.WriteLine("4.Стаж преподавателей");
            Console.WriteLine("5.Выход");
        }
        static List<prepod> zapolprepod()
        {
            List<prepod> prepod = new List<prepod>();
            Console.WriteLine("Преподаватели");
            while (true)
            {
                Console.WriteLine("Введите ФИО преподавателя:");
                string? fio = Console.ReadLine();
                if (fio == "")
                {
                    break;
                    Console.WriteLine("----------------------------------------");
                }
                prepod prepod1 = new prepod();
                prepod1.stagall = 0;
                prepod1.FIO = fio;
                Console.WriteLine("Введите дату рождения(год.месяц.день):");
                prepod1.godrog = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Введите предмет/предметы:");
                    string? predmet = Console.ReadLine();
                    if (predmet == "")
                    {
                        break;
                        Console.WriteLine("----------------------------------------");
                    }
                    prepod1.predmet.Add(predmet);
                    Console.WriteLine("----------------------------------------");
                }
                while (true)
                {
                    Console.WriteLine("Дата устройства(год.месяц.день):");
                    string? ustr = Console.ReadLine();
                    if (ustr == "")
                    {
                        break;
                        Console.WriteLine("----------------------------------------");
                    }
                    string? uvol = Console.ReadLine();
                    TimeSpan stag = DateTime.Parse(uvol) - DateTime.Parse(ustr);
                    prepod1.stagall += int.Parse(stag.Days.ToString());
                    Console.WriteLine("----------------------------------------");
                }
                prepod.Add(prepod1);
            }
            return prepod;
            Console.Clear();
        }
        static List<spec> zapolspec(){
            List<spec> spec = new List<spec>();
            Console.WriteLine("Специальные работники:");
            while (true)
            {
                Console.WriteLine("Введите ФИО работника:");
                string? fio = Console.ReadLine();
                if (fio == "")
                {
                    break;
                    Console.WriteLine("----------------------------------------");
                }
                spec spec1 = new spec();
                spec1.FIO = fio;
                Console.WriteLine("Введите дату рождения(год.месяц.день):");
                spec1.godrog = Console.ReadLine();
                Console.WriteLine("Введите должность:");
                spec1.dolgnost = Console.ReadLine();
                spec.Add(spec1);
            }
            return spec;
            Console.Clear();
        }
        static List<upr> zapolupr(){
            List<upr> upr = new List<upr>();
            Console.WriteLine("Управляющий персонал:");
            while (true)
            {
                Console.WriteLine("Введите ФИО работника:");
                string? fio = Console.ReadLine();
                if (fio == "")
                {
                    break;
                    Console.WriteLine("----------------------------------------");
                }
                upr upr1 = new upr();
                upr1.FIO = fio;
                Console.WriteLine("Введите дату рождения(год.месяц.день):");
                upr1.godrog = Console.ReadLine();
                Console.WriteLine("Введите должность");
                upr1.dolgnost = Console.ReadLine();
                Console.WriteLine("Введите приказ/приказы:");
                while (true)
                {
                    Console.WriteLine("Введите название приказа:");
                    string? naim = ('"' + Console.ReadLine() + '"');
                    if (naim == "")
                    {
                        break;
                        Console.WriteLine("----------------------------------------");
                    }
                    Console.WriteLine("От какого числа приказ(год.месяц.день):");
                    string data = Console.ReadLine();
                    Console.WriteLine("Для кого:");
                    string dlykogo = Console.ReadLine();
                    string prikaz = $"Приказ {naim} от {data} для {dlykogo}";
                    upr1.ukaz.Add(prikaz);
                    Console.WriteLine("----------------------------------------");
                }
                upr.Add(upr1);
            }
            return upr;
            Console.Clear();
        }
        static List<student> zapolstudent(){
            
            List<student> student = new List<student>();
            Console.WriteLine("Cтуденты:");
            while (true)
            {
                Console.WriteLine("Введите ФИО студента:");
                string? fio = Console.ReadLine();
                if (fio == "")
                {
                    break;
                    Console.WriteLine("----------------------------------------");
                }
                student student1 = new student();
                student1.FIO = fio;
                Console.WriteLine("Введите дату рождения(год.месяц.день):");
                student1.godrog = Console.ReadLine();
                Console.WriteLine("Введите оценки студента по предметам:");
                while (true)
                {
                    Console.WriteLine("Введите оценку:");
                    string ocenka = Console.ReadLine();
                    if (ocenka == "")
                    {
                        break;
                        Console.WriteLine("----------------------------------------");
                    }
                    Console.WriteLine("Введите предмет:");
                    string predmet = Console.ReadLine();
                    Console.WriteLine("Введите преподавателя:");
                    string prep = Console.ReadLine();
                    student1.ocenki.Add(prep +" " + predmet + " " + ocenka);
                    Console.WriteLine("----------------------------------------");
                }
                student.Add(student1);
            }
            return student;
            Console.Clear();
        }
        static void viborkastudsdolg(List<student> studenti){
            foreach (student student in studenti)
            {
                foreach (string ocen in student.ocenki){
                    if (ocen.Split(" ")[2]=="2"){
                        Console.WriteLine(student.FIO);
                        break;
                    }
                }
            }
        }
        static void viborkaprepsdolg(List<student> studenti){
            List<string> prepsdolg=new List<string>();
            foreach (student student in studenti)
            {
                foreach (string ocen in student.ocenki){
                    if (ocen.Split(" ")[2]=="2"){
                        prepsdolg.Add(ocen.Split(" ")[0]);
                    }
                }
            }
            for (int i = 0; i < prepsdolg.Count; i++)
            {
                for (int j =i+1; j+1 < prepsdolg.Count; j++){
                    if (prepsdolg[i]==prepsdolg[j]){
                        prepsdolg.RemoveAt(j);
                    }
                }
            }
            foreach(string c in prepsdolg){
                Console.WriteLine(c);
            }
        }
        static void vivorkaprikaz(List<upr> upri){
            foreach(upr upr in upri){
                foreach(string prikaz in upr.ukaz){
                    Console.WriteLine(prikaz);
                }
            }
        }
        static void viborkastag(List<prepod> prepodi){
            foreach(prepod prepod in prepodi){
                Console.WriteLine(prepod.FIO + " " + Convert.ToString(prepod.stagall));
            }
        }
    }
    class ludi
    {
        public string? FIO;
        public string? godrog;
    }
    class prepod : ludi
    {
        public List<string?>? predmet;
        public int stagall;
    }
    class spec : ludi
    {
        public string? dolgnost;
    }
    class upr : ludi
    {
        public string? dolgnost;
        public List<string>? ukaz;
    }
    class student : ludi
    {
        public List<string?>? ocenki;
    }
}