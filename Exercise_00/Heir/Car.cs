using Exercise_00.Parent;

namespace Exercise_00.Heir;

// Класс описывает транспортное средство легковой автомобиль
class Car : Transport, ICloneable
{
    public string CarBrand { get; set; }
    public string CarModel { get; set; }
    public string RegistrationNumber { get; set; }
    public string CarColor { get; set; }
    public DateTime CarYearManufacture { get; set; }
    public string CarType { get; set; }

    public Car(string brand, string model, string number, string color, DateTime dateTime, string type)
        : base(type)
    {
        CarBrand = brand;
        CarModel = model;
        RegistrationNumber = number;
        CarColor = color;
        CarYearManufacture = dateTime;
        CarType = type;
    }

    // Переопределяем функцию клонирования
    public override Car MyFunctionClone()
    {
        return new Car(CarBrand, CarModel, RegistrationNumber, CarColor, CarYearManufacture, CarType);
    }

    public override object Clone()
    {
        return new Car(CarBrand, CarModel, RegistrationNumber, CarColor, CarYearManufacture, CarType);
    }

    public override void GetInformation()
    {
        Console.WriteLine(
            $"\nCar Information:\n" +
            $"--------------------------\n" +
            $"Brand:                {CarBrand}\n" +
            $"Model:                {CarModel}\n" +
            $"Transport Type:       {CarType}\n" +
            $"Registration Number   {RegistrationNumber}\n" +
            $"CarColor              {CarColor}\n" +
            $"Year Of Manufacture:  {CarYearManufacture}");
    }
}


