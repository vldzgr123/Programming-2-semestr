using System.Collections;
while(true){
    Console.WriteLine("1.Меню с методами");
    Console.WriteLine("2.Проверка правильности ввода скобок");
    Console.WriteLine("3.Выход");
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==3){
       break; 
    }
    if (n>0 && n<4){
        switch(n){
            case 1:
                Console.Clear();
                method();
                break;
            case 2:
                Console.Clear();
                proverka();
                break;
        }
        
    }
    else Console.WriteLine("Ошибка!");
}

static void menumethod(){
    Console.WriteLine("1.Push");
    Console.WriteLine("2.Pop");
    Console.WriteLine("3.Peek");
    Console.WriteLine("4.Contains");
    Console.WriteLine("5.Clear");
    Console.WriteLine("6.Count");
    Console.WriteLine("7.Вывод Массива");
    Console.WriteLine("8.Выход");
}
static void method(){
    var stck = new Stack<string>();
    Console.WriteLine("Введите элементы:");
    while (true)
    {
        string? n =Console.ReadLine();
        if (n=="") break;
        stck.Push(n);
    }
    Console.Clear();
    while(true){
        menumethod();
        int n=Convert.ToInt32(Console.ReadLine());
        if (n==8)
            break;
        if (n>0 && n<9){
            switch(n){
            case 1://Push1
                Console.Clear();
                Console.WriteLine("Введите элемент, который нужно добавить:");
                string ff=Console.ReadLine();
                Console.WriteLine("Массив до:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                stck.Push(ff);
                Console.WriteLine("");
                Console.WriteLine("Массив после:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                break;
            case 2://Pop1
                Console.Clear();
                Console.WriteLine("Массив до:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("Элемент:");
                Console.WriteLine(stck.Pop());
                Console.WriteLine("Массив после:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                break;
            case 3://Peek1
                Console.Clear();
                Console.WriteLine("Массив до:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("Элемент:");
                Console.WriteLine(stck.Peek());
                Console.WriteLine("Массив после:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                break;
            case 4://Contains1
                Console.Clear();
                Console.WriteLine("Введите элемент:");
                Console.WriteLine(stck.Contains(Console.ReadLine()));
                Console.WriteLine("=======================================================");
                break;
            case 5://Clear1
                Console.Clear();
                Console.WriteLine("Массив до:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                stck.Clear();
                Console.WriteLine("Массив после:");
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Количество элементов:");
                Console.WriteLine(stck.Count);
                Console.WriteLine("=======================================================");
                break;
            case 7:
                Console.Clear();
                foreach(var f in stck){
                    Console.Write(f+" ");
                }
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                Console.WriteLine("");
                break;
            }
        }
        else{
            Console.WriteLine("Ошибка!");
        }
    }
}
static void proverka(){
    Console.WriteLine("Введите строку:");
    var lst=new Dictionary<char,char>(){
        {'{','}'},
        {'[',']'},
        {'(',')'}
    };
    string str=Console.ReadLine();
    var stc=new Stack<char>();
    var strmas=str.ToCharArray();
    for(int i=0;i<strmas.Length;i++){
        if (lst.ContainsKey(strmas[i])){
            stc.Push(strmas[i]);
            for (int j=i+1;j<strmas.Length;j++){
                if (lst.ContainsValue(strmas[j]) && lst[strmas[i]]==strmas[j]){
                    stc.Push(strmas[j]);
                    strmas[j]='0';
                    break;
                }
            }
        }
        if (lst.ContainsValue(strmas[i])) stc.Push(strmas[i]);
    }
    bool check=true;
    char tmp,tmk;
    while (stc.Count!=0){
        tmp=stc.Pop();
        tmk=stc.Pop();
        try{
            if (lst[tmk]!=tmp){
                check=false;
                break;
        }
        }
        catch{
            check=false;
            break;
        }
    }
    Console.WriteLine(check);
    Console.WriteLine("=======================================================");
}
