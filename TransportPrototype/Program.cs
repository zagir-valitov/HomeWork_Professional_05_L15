using TransportPrototype;


Console.WriteLine("--- Home Work 5. Transport prototypes ---\n");

//TransportCloned();
//CarCloned();
ConcretCarCloned();

void ConcretCarCloned()
{
    Ford ford = new Ford(
        "Ford focus 3",
        new Transmission("Ручная коробка передач", 5),
        new Engine("Бензиновый двигатель", 125),
        "Универсал",
        5,
        "Белый",
        "123CBA654",
        "Наземный",
        "Легковой",
        "987QAZ123XDR");
    Ford fordCloned1 = ford.MyClone();
    Ford fordCloned2 = (Ford)ford.Clone();
    ford.GetInfo();
    fordCloned1.GetInfo();
    fordCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    fordCloned1.Model = "Mondeo";
    fordCloned1.Transmission = new Transmission("Автоматическая коробка передач", 8);
    fordCloned1.Engine = new Engine("Дизельный двигатель", 250);
    ford.GetInfo();
    fordCloned1.GetInfo();
    fordCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    fordCloned2.Transmission.TransmissioType = "Роботизированная коробка передач";
    ford.GetInfo();
    fordCloned1.GetInfo();
    fordCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    fordCloned1.Transmission.TransmissioType = "Вариаторная коробка передач";
    ford.GetInfo();
    fordCloned1.GetInfo();
    fordCloned2.GetInfo();
    Console.WriteLine("*****************************************************");
}

void CarCloned()
{
    Car car = new Car("Наземный", "123", "Легковой" );
    Car carCloned1 = car.MyClone();
    Car carCloned2 = (Car)car.Clone();
    car.GetInfo();
    carCloned1.GetInfo();
    carCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    car.CarType = "Грузовой";
    car.TransportId = "qwe";
    car.GetInfo();
    carCloned1.GetInfo();
    carCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    carCloned1.CarType = "Спортивный";
    carCloned1.TransportId = "ABC";
    car.GetInfo();
    carCloned1.GetInfo();
    carCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    carCloned2.CarType = "Спецтранспорт";
    carCloned2.TransportId = "4V5";
    car.GetInfo();
    carCloned1.GetInfo();
    carCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

}

void TransportCloned()
{
    Transport transport = new Transport("123");
    Transport transportCloned1 = transport.MyClone();
    Transport transportCloned2 = (Transport)transport.Clone();
    transport.GetInfo();
    transportCloned1.GetInfo();
    transportCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    transport.TransportId = "456";
    transport.GetInfo();
    transportCloned1.GetInfo();
    transportCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    transportCloned1.TransportId = "789";
    transport.GetInfo();
    transportCloned1.GetInfo();
    transportCloned2.GetInfo();
    Console.WriteLine("*****************************************************");

    transportCloned2.TransportId = "654";
    transport.GetInfo();
    transportCloned1.GetInfo();
    transportCloned2.GetInfo();
}













/*
var fordFocus3 = new Ford(
    "Ford focus 3",
    new Transmission("Ручная коробка передач", 5),
    new Engine("Бензиновый двигатель", 125),
    "Универсал",
    5,
    "Белый",
    "123CBA654",
    "Наземный",
    "Легковой");

*/