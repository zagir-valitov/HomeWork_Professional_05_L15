namespace TransportPrototype;

/// <summary>
/// Класс описывает трансмиссию транспортного средства в упрощенном виде
/// </summary>
public class Transmission
{
    /// <summary>
    /// Приватное поле хранит текущее значение скоростных передачи
    /// </summary>
    private int _currentGear;

    /// <summary>
    /// Приватное поле хранит максимальное значение скоростных передач трансмисии
    /// </summary>
    private int _gearsNumber;

    /// <summary>
    /// Свойство определяет тип трансмиссии (например: автоматическая, ручная и т.д.)
    /// </summary>
    public string? TransmissioType { get; set; }

    /// <summary>
    /// Свойство определяет количество скоростных передач трансмиссии
    /// </summary>
    public int GearsNumber 
    { 
        get => _gearsNumber; 
        set => _gearsNumber = value; 
    }

    /// <summary>
    /// Свойство определяет текущую скоростную передачу <see cref="_currentGear"/>
    /// </summary>
    public int CurrentGear
    {
        set
        {
            if (value < 0 || value > _gearsNumber)
            {
                Console.WriteLine($"Скоростная передача задаётся в диапозоне 0 - {_gearsNumber}");
            }
            else
            {
                _currentGear = value;
            }
        }
        get { return _currentGear; }
    }

    /// <summary>
    /// Конструктор класса принимает тип трансмиссии и количество скоростных передач
    /// </summary>
    public Transmission(string? transmissioType, int gearsNumber )
    {
        TransmissioType = transmissioType;
        GearsNumber = gearsNumber;              
    }

    /// <summary>
    /// Метод задаёт скоростную передачу трансмиссии
    /// </summary>
    /// <param name="gear">номер передачи скорости</param>
    public virtual void SetGear(int gear)
    {
        CurrentGear = gear;
    }

    /// <summary>
    /// Метод отображает текущую скоростную передачу трансмиссии
    /// </summary>
    public virtual void DisplayCurrentGear()
    {
        Console.WriteLine($"Текущая передача трансмисии: {CurrentGear}");
    }
}
