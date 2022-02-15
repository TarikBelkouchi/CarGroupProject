using CarGroupProject;

Cars Mustang = new Cars("Ford", "Mustang", 1969, 50000);
Console.WriteLine(Mustang.ToString());
UsedCars Golf = new UsedCars("VW", "Golf", 2002, 10000, 78000);
Console.WriteLine(Golf.ToString());

List<Cars> cars = new List<Cars>();
cars.Add(Mustang);
cars.Add(Golf);
CarLot myCarLot = new CarLot();
myCarLot.AddCarLotList(Mustang);
myCarLot.AddCarLotList(Golf);
myCarLot.PrintCarLotList();
Console.WriteLine();

myCarLot.RemoveCarLotList(Golf);
myCarLot.PrintCarLotList();
