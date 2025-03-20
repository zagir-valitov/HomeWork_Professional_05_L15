using System.Drawing;
using System.Reflection;

namespace TransportPrototype;

/// <summary>
/// Конкретная реализация абстрактного класса <see cref="Car"/>
/// </summary>
public class Ford : Car
{
    /// <summary>
    /// Поле задаёт модель автомобиля <see cref="Ford"/>
    /// </summary>
    public string? Model;

    /// <summary>
    /// Поле задает трансмиссию автомобиля <see cref="Ford"/>
    /// </summary>
    public Transmission Transmission;

    /// <summary>
    /// Поле задает двигатель автомобиля <see cref="Ford"/> 
    /// </summary>
    public Engine Engine;

    /// <summary>
    /// Поле задает тип кузова (например: седан, хэтчбекб, универсал и т.д.)
    /// </summary>
    public string? BodyType;

    /// <summary>
    /// Поле задает количество дверей автомобиля
    /// </summary>
    public int DoorsNumber;

    /// <summary>
    /// Поле задает цвет кузова автомобиля
    /// </summary>
    public string? Color;

    /// <summary>
    /// Поле задает vin номер автомобиля
    /// </summary>
    public string? VIN;

    /// <summary>
    /// Конструктор класса <see cref="Ford"/>
    /// </summary>
    /// <param name="transmission">Тип трансмиссии и количество скоростных передач</param>
    /// <param name="engine">Параметры двигателя</param>
    /// <param name="bodyType">Тип кузова</param>
    /// <param name="doorsNumber">Количество дверей</param>
    /// <param name="color">Цвет кузова</param>
    /// <param name="vin">Уникальный номер автомобиля</param>
    public Ford(string? model, Transmission transmission, Engine engine, string? bodyType, 
        int doorsNumber, string? color, string? vin, string? transportType, string? carType, string? transportId)
        :base(transportType, carType, transportId)
    {
        Model = model;
        Transmission = transmission;
        Engine = engine;
        BodyType = bodyType;
        DoorsNumber = doorsNumber;
        Color = color;
        VIN = vin;
        TransportType = transportType;
        CarType = carType;
        TransportId = transportId;
    }

    /// <summary>
    /// Метод отображает в консоле полную информацию об автомобиле <see cref="Ford"/>
    /// </summary>
    public override void GetInfo()
    {
        Console.WriteLine(
            $"Описание автомобиля {Model}:\n" +
            $"-----------------------------------------------------\n" +
            $"Трансмиссия:          {Transmission?.TransmissioType}, {Transmission?.GearsNumber} ступ.\n" +
            $"Двигатель:            {Engine?.EngineType}, {Engine?.EnginePowerHp} л.с.\n" +
            $"Тип кузва:            {BodyType}\n" +
            $"Количество дверей:    {DoorsNumber}\n" +
            $"Цвет кузова:          {Color}\n" +
            $"VIN:                  {VIN}\n" +
            $"Тип транспорта:       {TransportType}\n" +
            $"Тип автомобиля:       {CarType}\n" +
            $"Номер шасси:          {TransportId}\n");
    }

    public override void Move()
    {
        if(Transmission?.CurrentGear != 0)
        {
            Console.WriteLine($"Автомобиль {Model} едет на {Transmission?.CurrentGear} передаче");
        }
        else
        {
            Console.WriteLine($"Автомобиль {Model} не едет");
        }        
    }

    /// <summary>
    /// Реализация метода клонирования пользовательского интерфейса <see cref="IMyCloneable{T}"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Ford"/> </returns>
    public Ford MyClone()
    {
        return new Ford(
            Model, 
            new Transmission(Transmission.TransmissioType, Transmission.GearsNumber), 
            new Engine(Engine.EngineType, Engine.EnginePowerHp), 
            BodyType, 
            DoorsNumber, 
            Color, 
            VIN, 
            TransportType, 
            CarType, 
            TransportId);
    }

    /// <summary>
    /// Реализация метода клонирования пользовательского интерфейса <see cref="ICloneable{T}"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Ford"/> </returns>
    public object Clone()
    {
        return MemberwiseClone();
    }
}
