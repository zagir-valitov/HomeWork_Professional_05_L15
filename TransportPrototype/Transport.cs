using System.Drawing;
using System.Reflection;

namespace TransportPrototype;

/// <summary>
/// Класс описывает транспортное средство
/// </summary>
public class Transport : IMyCloneable<Transport>, ICloneable
{
    /// <summary>
    /// Уникальный номер транспортного средства
    /// </summary>
    public string? TransportId;

    /// <summary>
    /// Конструктор класса <see cref="Transport"/>
    /// </summary>
    public Transport(string? transportId) 
    {
        TransportId = transportId;
    }
        
    /// <summary>
    /// Метод передвижения транспортного средства в классе наследнике
    /// </summary>
    public virtual void Move()
    {
        Console.WriteLine($"Транспорт  едет. ID: {TransportId}");
    }

    /// <summary>
    /// Метод отображает в консоле полную информацию о транспорте <see cref="Transport"/>
    /// </summary>
    public virtual void GetInfo()
    {
        Console.WriteLine(
            $"Описание транспорта:\n" +
            $"-----------------------------------------------------\n" +
            $"Уникальный номер:     {TransportId}\n");
    }

    /// <summary>
    /// Реализация метода клонирования пользовательского интерфейса <see cref="IMyCloneable{T}"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Transport"/> </returns>
    public Transport MyClone()
    {
        return new Transport(TransportId);
    }

    /// <summary>
    /// Реализация метода клонирования стандартного интерфейса <see cref="ICloneable"/>
    /// </summary>
    /// <returns> Клон объекта <see cref="Transport"/> </returns>
    public object Clone()
    {
        return MemberwiseClone();
    }
}
