
using Exercise_00;

Console.WriteLine("--- Home Work 5. Exercise 0 ---\n");

var ford = new Ford(
    "Ford focus 3", 
    "hatchback", 
    "midnight sky", 
    "123ABC", 
    new Transmission("автоматическая", 6),
    "легковой",
    "наземный"
    );


var fordCloned1 = (Ford)ford.Clone();
var fordCloned2 = ford.MyClone();


ford.CarType = "Спортивный";

ford.GetInfo();
fordCloned1.GetInfo();
fordCloned2.GetInfo();

Console.WriteLine("\n======================================\n");

ford.TransportType = "Трековый";
ford.Color = "Red";

ford.Transmission.TransmissionType = "Ручная";
ford.Transmission.GearsNumber = 5;

ford.GetInfo();
fordCloned1.GetInfo();
fordCloned2.GetInfo();
