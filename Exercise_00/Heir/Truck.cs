using Exercise_00.Parent;

namespace Exercise_00.Heir;
// Класс описывает транспортное средство грузовик
class Truck : Transport, ICloneable
{
    public string TruckBrand { get; set; }
    public string TruckModel { get; set; }
    public string RegistrationNumber { get; set; }
    public string TruckColor { get; set; }
    public DateTime TruckYearManufacture { get; set; }
    public string TruckType { get; set; }

    public Truck(string brand, string model, string number, string color, DateTime dateTime, string type)
        : base(type)
    {
        TruckBrand = brand;
        TruckModel = model;
        RegistrationNumber = number;
        TruckColor = color;
        TruckYearManufacture = dateTime;
        TruckType = type;
    }

    // Переопределяем функцию клонирования
    public override Truck MyFunctionClone()
    {
        return new Truck(TruckBrand, TruckModel, RegistrationNumber, TruckColor, TruckYearManufacture, TruckType);
    }

    public override object Clone()
    {
        return new Truck(TruckBrand, TruckModel, RegistrationNumber, TruckColor, TruckYearManufacture, TruckType);
    }

    public override void GetInformation()
    {
        Console.WriteLine(
            $"\nTrack Information:\n" +
            $"--------------------------\n" +
            $"Brand:                {TruckBrand}\n" +
            $"Model:                {TruckModel}\n" +
            $"Transport Type:       {TruckType}\n" +
            $"Registration Number   {RegistrationNumber}\n" +
            $"TruckColor            {TruckColor}\n" +
            $"Year Of Manufacture:  {TruckYearManufacture}");
    }
}
