using Prototype;

Console.WriteLine("=== Создадим ElectricCar === ");
ElectricCar ec_original = new ElectricCar("Electric", 4, 100);
ElectricCar ec_myClone = (ElectricCar)ec_original.Clone();
ElectricCar ec_systemClone = (ElectricCar)(ec_original as ICloneable).Clone();

Console.WriteLine("Оригинал: " + ec_original.Type + " " + ec_original.Wheels + " " + ec_original.BatteryCapacity + "квт/ч");
Console.WriteLine("Клон IMyCloneable: " + ec_myClone.Type + " " + ec_myClone.Wheels + " " + ec_myClone.BatteryCapacity + "квт/ч");
Console.WriteLine("Клон ICloneable: " + ec_original.Type + " " + ec_original.Wheels + " " + ec_systemClone.BatteryCapacity + "квт/ч");
Console.WriteLine("Оригинал == MyClone? " + ReferenceEquals(ec_original, ec_myClone) + "\n"); // False


Console.WriteLine("=== Создадим Truck === ");
Truck t_original = new Truck("Truck", 8, 18);
Truck t_myClone = (Truck)t_original.Clone();
Truck t_systemClone = (Truck)(t_original as ICloneable).Clone();

Console.WriteLine("Оригинал: " + t_original.Type + " " + t_original.Wheels + " " + t_original.Сarrying + "т");
Console.WriteLine("Клон IMyCloneable: " + t_myClone.Type + " " + t_myClone.Wheels + " " + t_myClone.Сarrying + "т");
Console.WriteLine("Клон ICloneable: " + t_systemClone.Type + " " + t_systemClone.Wheels + " " + t_systemClone.Сarrying + "т");
Console.WriteLine("Оригинал == MyClone? " + ReferenceEquals(t_original, t_myClone) + "\n"); // False
