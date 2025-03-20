namespace TransportPrototype;

/// <summary>
/// Класс описывает двигатель в упрощенном виде
/// </summary>
public class Engine
{
    /// <summary>
    /// Свойство определяет тип двигателя (например: бензиновый, дизельный, газовый и т.д.)
    /// </summary>
    public string EngineType { get; set; }

    /// <summary>
    /// Свойство определяет мощность двигателя в лошидиных силах
    /// </summary>
    public int EnginePowerHp { get; set; }

    /// <summary>
    /// Конструктор класса Engine 
    /// </summary>
    /// <param name="engineType"></param>
    /// <param name="enginePowerHp"></param>
    public Engine(string engineType, int enginePowerHp)
    {
        EngineType = engineType;
        EnginePowerHp = enginePowerHp;
    }
}

