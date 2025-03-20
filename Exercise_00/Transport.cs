namespace Exercise_00;

/// <summary>
/// Абстрактный класс Transport описывает абстракцию транспортное средство
/// <para>Имеет единственное поле TransportType типа string, 
/// которое задает тип транспортного средства. Например: наземный, подземный, воздушный и т.д.</para>
/// <para></para>
/// </summary>
abstract class Transport : IMyCloneable<Transport>, ICloneable
{
    public string? TransportType;

    /// <summary>
    /// Абстрактный метод Move() для реализации движения транспортного средства
    /// </summary>
    public abstract void Move();

    /// <summary>
    /// Для реализации метода клонирования интерфейса IMyCloneable
    /// </summary>
    public abstract Transport MyClone();

    /// <summary>
    /// Для реализации метода клонирования стандартного интерфейса ICloneable
    /// </summary>
    public abstract object Clone();
}
