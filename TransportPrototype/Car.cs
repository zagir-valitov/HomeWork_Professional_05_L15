namespace TransportPrototype;

/// <summary>
/// Абстракный класс описывает транспортное средство автомобиль и наследует абстрактный класс <see cref="Transport"/>
/// </summary>
public class Car : Transport
{
    /// <summary>
    /// Свойство определяет к какому типу относится транспортное средство (например: наземный, водный, воздушный и т.д.)
    /// </summary>
    public string? TransportType { get; set; }

    /// <summary>
    /// Свойство определяет к какому типу относится автомобиль (например: легковой, грузовой, спортивный и т.д.)
    /// </summary>
    public string? CarType { get; set; }

    /// <summary>
    /// Конструктор класса <see cref="Car"/>
    /// </summary>
    /// <param name="transportType">тип транспорта</param>
    /// <param name="carType"> тип автомобиля</param>
    public Car(string? transportType, string? transportId, string? carType)
        :base(transportId)
    {
        TransportType = transportType;
        TransportId = transportId;
        CarType = carType;        
    }

    /// <summary>
    /// Реализация метода наследуемого абстракного класса <see cref="Transport.Move()"/>
    /// </summary>
    public override void Move()
    {
        Console.WriteLine("Автомобиль едет");
    }

    /// <summary>
    /// Метод отображает в консоле полную информацию об автомобиле <see cref="Car"/>
    /// </summary>
    public override void GetInfo()
    {
        Console.WriteLine(
            $"Описание автомобиля:\n" +
            $"-----------------------------------------------------\n" +
            $"Тип транспорта:       {TransportType}\n" +
            $"Номер кузова:         {TransportId}\n" +
            $"Тип автобомиля:       {CarType}\n");
    }

    /// <summary>
    /// Реализация метода клонирования пользовательского интерфейса <see cref="IMyCloneable{T}"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Car"/> </returns>
    public Car MyClone()
    {
        return new Car(TransportType, TransportId, CarType);
    }

    /// <summary>
    /// Реализация метода клонирования пользовательского интерфейса <see cref="ICloneable{T}"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Car"/> </returns>
    public object Clone()
    {
        return MemberwiseClone();
    }
}
