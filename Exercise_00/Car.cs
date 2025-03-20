namespace Exercise_00;

/// <summary>
/// Абстрактный класс Car наследует абстракный класс <see cref="Transport"/>
/// </summary>
abstract class Car : Transport
{
    public string? CarType;

    public override void Move()
    {
        Console.WriteLine("Автомобиль едет");
    }

    public override abstract  Car MyClone();

    public override abstract object Clone();       
}
