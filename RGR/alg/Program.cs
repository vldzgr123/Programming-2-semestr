
while(true){
    Console.WriteLine("1.Игра\n2.Об авторе\n3.Выход");
    string n=Console.ReadLine();
    if(n=="3") break;
    switch(n){
        case "1":
            Console.Clear();
            Game();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Об авторе:\nЗагребельный Владислав, студент группы ФИТ-221.");
            Console.WriteLine("==============================================");
            break;
    }
}
static void Game(){
    bool check=false;
    Console.WriteLine("Введите скольки значное будет угадываться число (количество цифр в числе):");
    int k=Convert.ToInt32(Console.ReadLine());
    var num=Randomizer(k-1);
    Console.WriteLine("Введите число попыток:");
    int n=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("==============================================");
    Console.WriteLine("Введите k-значное число (без повторяющихся цифр):");
    for(int j=0;j<n;j++){
        var inputNum=Console.ReadLine().ToCharArray();
        if(inputNum.Count()!=k || inputNum.Distinct().Count()!=k || inputNum[0]=='0'){
            Console.WriteLine("Число введено некорректно!");
            j--;
        }
        else{
            if(string.Join("",num)==string.Join("",inputNum)){

                Console.WriteLine("Вы угадали число!");
                Console.WriteLine("==============================================");
                check=true;
                break;
            }
            else{
                int countCoincidence=0;
                int countCoincidencePlace=0;
                for (int i=0;i<k;i++){
                    if (inputNum[i]==num[i]){
                        countCoincidencePlace++;
                    }
                    if (num.Contains(inputNum[i])){
                        countCoincidence++;
                    }
                }
                Console.WriteLine($"Количество цифр угадано: {countCoincidence}\nКоличество цифр угадано и стоит на нужном месте: {countCoincidencePlace}");
                Console.WriteLine("==============================================");
                if (n-j-1!=0) Console.WriteLine($"Введите число еще раз(осталось попыток {n-j-1}):");
            }
        }
    }
    if(check==false){
        Console.WriteLine("Попытки кончились!");
    }
}
static char[] Randomizer(int x){
    Random rnd=new Random();
    while(true){
        char[] num=rnd.Next(Convert.ToInt32(Math.Pow(10,x)),Convert.ToInt32(Math.Pow(10,x+1))).ToString().ToCharArray();
        if ((num.Distinct()).Count()==num.Count()){
            return num;
        }
    }
}