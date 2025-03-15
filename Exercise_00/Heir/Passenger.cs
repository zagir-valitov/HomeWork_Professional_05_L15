using Exercise_00.Parent;

namespace Exercise_00.Heir;
// Класс описывает человека пассажира 
class Passenger : Person, ICloneable
{
    public string PassengerName { get; set; }
    public int PassengerAge { get; set; }
    public string PassengerGender { get; set; }
    public string PassengerCategory { get; set; } = "Ordinary";
    public bool HavePet { get; set; }

    public Passenger(string name, int age, string gender, string category, bool pet)
        : base(name, age, gender) 
    {
        PassengerName = name;
        PassengerAge = age;
        PassengerGender = gender;
        PassengerCategory = category;
        HavePet = pet;
    }

    // Переопределяем функцию клонирования
    public override Passenger MyFunctionClone()
    {
        return new Passenger(PassengerName, PassengerAge, PassengerGender, PassengerCategory, HavePet);
    }

    public override object Clone()
    {
        return new Passenger(PassengerName, PassengerAge, PassengerGender, PassengerCategory, HavePet);
    }

    public override void GetInformation()
    {
        Console.WriteLine(
            $"\nPassenger Information:\n" +
            $"--------------------------\n" +
            $"Name:                 {Name}\n" +
            $"Age:                  {Age}\n" +
            $"Gender                {Gender}\n" +
            $"PassengerCategory:    {PassengerCategory}");
    }
}
