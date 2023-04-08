using System.Collections;

Hashtable tabl = new Hashtable();
Console.WriteLine("Введите ключ и элементы (через пробел):");
while (true)
{
    string? str =Console.ReadLine();
    if (n=="") break;
    string[] n=str.Split(" ");
    table.Add(n[0],n[1]);
}
Console.Clear();
while(true){
    menu();
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==11)
        break;
    if (n>0 && n<12){
        switch(n){
        case 1:/*ContainsValue*/
            Console.Clear();
            Console.WriteLine("Введите элемент:");
            Console.WriteLine(tabl.Contains(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;
            /*
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){                        
                Console.Write(f+" ");
            }
            lst.Sort();
            Console.WriteLine("");
            Console.WriteLine("Массив после");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
            */
        case 2:/*ContainsKey*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            Console.WriteLine(tabl.ContainsKey(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;
            // Console.Clear();
            // Console.WriteLine("Введите элемент, индекс которого нужно найти (первое вхождение):");
            // var c=Console.ReadLine();
            // Console.WriteLine("Индекс:" +lst.IndexOf(c));                
            // Console.WriteLine("=======================================================");
            // break;
        case 3:/*Equals*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            string n=Console.ReadLine();
            Console.WriteLine("Введите значение:");
            Console.WriteLine(tabl[n].Equals(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            // Console.Clear();
            // Console.WriteLine("Введите элемент, индекс которого нужно найти (последнее вхождение):");
            // var g=Console.ReadLine();
            // Console.WriteLine("Индекс:" +lst.LastIndexOf(g));
            // Console.WriteLine("=======================================================");
            // break;
        case 4:/*Copyto*/
            Console.Clear();
            Console.WriteLine("Введите кол-во элементов массива:");
            string[] test=new string[Convert.ToInt32(Console.ReadLine)];
            Console.WriteLine("Массив до:");
            for (int i = 0; i < test.Length; i++)
            {
                test[i]="0";
                Console.Write(test[i]+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Введите индекс:");
            tabl.CopyTo(test,Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Массив после:");
            foreach(var f in lst){                        
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            // Console.Clear();
            // Console.WriteLine("Массив до:");
            // foreach(var f in lst){
            //     Console.Write(f+" ");
            // }
            // Console.WriteLine("");
            // lst.Reverse();
            // Console.WriteLine("Массив после:");
            // foreach(var f in lst){
            //     Console.Write(f+" ");
            // }
            // Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 5:/*Clear*/
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Clear();
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 6:/*Insert*/
            Console.Clear();
            Console.WriteLine($"Введите индекс (до {lst.Count}):");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объект, на который нужно заменить");
            var p =Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Insert(q,p);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 7:/*Remove*/
            Console.Clear();
            Console.WriteLine("Введите элемент, который нужно удалить из списка (первое вхождение)");
            var k=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Remove(k);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 8:/*Count*/
            Console.Clear();
            Console.WriteLine("Количество элементов:");
            Console.WriteLine(lst.Count);
            Console.WriteLine("=======================================================");
            break;
        case 9:/*RemoveAt*/
            Console.Clear();
            Console.WriteLine("Введите индекс:");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.RemoveAt(l);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 10:/*Вывод массива*/
            Console.Clear();
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
        break;
    }
    }
    else{
        Console.WriteLine("Ошибка!");
    }
}
static void menu(){
    Console.WriteLine("1.ContainsValue");
    Console.WriteLine("2.ContainsKey");
    Console.WriteLine("3.Equals");
    Console.WriteLine("4.Reverse");
    Console.WriteLine("5.Clear");
    Console.WriteLine("6.Insert");
    Console.WriteLine("7.Remove");
    Console.WriteLine("8.Count");
    Console.WriteLine("9.RemoveAt");
    Console.WriteLine("10.Вывод Массива");
    Console.WriteLine("11.Выход");
}
