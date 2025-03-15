using Exercise_00.Heir;
using Exercise_00.Parent;

Console.WriteLine("--- Home Work 5. Exercise 0 ---\n");

var person = new Person("Anton", 39, "male");
var personClone = person.MyFunctionClone();
person.GetInformation();
personClone.GetInformation();
Console.WriteLine("*******************************************");

person.Name = "Victoria";
person.Age = 31;
person.Gender = "female";
person.GetInformation();
personClone.GetInformation();
Console.WriteLine("===========================================\n");

var car = new Car(
    "Toyota",
    "Camry",
    "A123BB",
    "Black",
    new DateTime(2024, 5, 15),
    "ground");

var carClone = car.MyFunctionClone();
car.GetInformation();
carClone.GetInformation();
Console.WriteLine("*******************************************");

carClone.CarBrand = "Ford";
carClone.CarModel = "Mondeo";
carClone.RegistrationNumber = "C456DD";
carClone.CarYearManufacture = new DateTime(2025, 1, 20);
car.GetInformation();
carClone.GetInformation();
Console.WriteLine("===========================================\n");