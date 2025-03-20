namespace Exercise_00;

class Ford : Car
{
    public string? Model;
    public string? BodyType;
    public string? Color;
    public string? VIN;
    public Transmission Transmission;
    
    public Ford(
        string? model, string? bodyType, string? color, string? vin, Transmission transmission, 
        string? carType, string? transportType) 
        //: base(carType, transportType)
    {
        Model = model;
        BodyType = bodyType;
        Color = color;
        VIN = vin;
        Transmission = transmission;
        CarType = carType;
        TransportType = transportType;
    }

    public override Ford MyClone()
    {
        var transmission = new Transmission(Transmission.TransmissionType, Transmission.GearsNumber);
        var ford = new Ford(Model, BodyType, Color, VIN, transmission, CarType, TransportType);
        ford.CarType = this.CarType;
        return ford;
    }

    public override object Clone()
    {        
        return (Ford)MemberwiseClone();
    }

    public void GetInfo()
    {
        Console.WriteLine(
            $"\nОписание: \n" +
            $"------------------------\n" +
            $"Модель:           {Model}\n" +
            $"Тип кузова:       {BodyType}\n" +
            $"Цвет кузова:      {Color}\n" +
            $"VIN:              {VIN}\n" +
            $"Трансмиссия:      {Transmission.TransmissionType} ({Transmission.GearsNumber})\n" +            
            $"Тип автомобиля:   {CarType}\n" +
            $"Тип транспорта:   {TransportType}");
    }
}
