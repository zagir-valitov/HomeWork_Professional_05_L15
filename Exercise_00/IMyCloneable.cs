namespace Exercise_00;

/// <summary>
/// Интерфейс с обобщенным типом Т поддерживает клонирование - создается новый экземпляр класса наследника с тем же значением
/// </summary>
interface IMyCloneable<T>
{
    /// <summary>
    /// Метод для реализации клонирования в классе наследнике
    /// </summary>
    /// <returns>T</returns>
    public abstract T MyClone();
}
