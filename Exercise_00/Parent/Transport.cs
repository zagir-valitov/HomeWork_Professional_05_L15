using Exercise_01;

namespace Exercise_00.Parent;

// Класс описывает транспорт в общем виде
class Transport : IMyCloneable<Transport>, ICloneable
{    
    public string TransportType { get; set; }      // тип передвижения. Наземный, водный, воздушный и тд
    
    public Transport(string type)
    {
        TransportType = type;
    }

    public virtual Transport MyFunctionClone()
    {
        return new Transport(TransportType);
    }

    public virtual object Clone()
    {
        return new Transport(TransportType);
    }

    public virtual void GetInformation()
    {
        Console.WriteLine(
            $"\nTransport Information:\n" +
            $"--------------------------\n" +
            $"Transport Type:       {TransportType}");
    }    
}

