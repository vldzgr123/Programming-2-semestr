var car1=new Car();
car1.id=1;
car1.color="Blue";
car1.mark="Toyta";
var car2=new Car();
car2.id=2;
car2.color="Green";
car2.mark="Toyta";
var car3=new Car();
car3.id=3;
car3.color="Black";
car3.mark="Lada";

var cars=new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
var sameMark=cars.GroupBy(x=>x.mark);// группировка машин по марке
foreach(var x in sameMark){
    Console.WriteLine(x.Key+ ":");
    foreach(var car in x){
        Console.WriteLine(car.id);
        Console.WriteLine(car.color);
    }
    Console.WriteLine();
}
Console.WriteLine($"===================================================\n");

Owner owner1=new Owner();
owner1.idCar=1;
owner1.name="Олег";
Owner owner2=new Owner();
owner2.idCar=1;
owner2.name="Петр";
Owner owner3=new Owner();
owner3.idCar=2;
owner3.name="Игорь";
Owner owner4=new Owner();
owner4.idCar=3;
owner4.name="аллАн";

var owners=new List<Owner>{ owner1,owner2,owner3,owner4 };

var sameIdCarOwner=owners.GroupBy(x=>x.idCar);// группировка владельцев по id машины

foreach(var group in sameIdCarOwner){
    Console.WriteLine(group.Key+":");
    foreach(var owner in group){
        Console.WriteLine(owner.name);
    }
    Console.WriteLine();
}


/////////////////////////////////////////////////////////////////////
class Car{
    public int id;
    public string color;
    public string mark;
}
class Owner{
    public int idCar;
    public string name;
}
