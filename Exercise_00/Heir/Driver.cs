using Exercise_00.Parent;

namespace Exercise_00.Heir;

// Класс описывает человика водителя
class Driver : Person
{
    public string DriverName { get; set; }
    public int DriverAge { get; set; }
    public string DriverGender { get; set; }
    public int DrivingExperience { get; set; }
    public string DriverLicense { get; set; }
    
    public Driver(string name, int age, string gender, int experience, string licensy)
        : base(name, age, gender) 
    {
        DriverName = name;
        DriverAge = age;
        DriverGender = gender;
        DrivingExperience = experience;
        DriverLicense = licensy;
    }

    // Переопределяем функцию клонирования
    public override Driver MyFunctionClone()
    {
        return new Driver(DriverName, DriverAge, DriverGender, DrivingExperience, DriverLicense);
    }

    public override void GetInformation()
    {
        Console.WriteLine(
            $"\nDriver Information:\n" +
            $"--------------------------\n" +
            $"Name:                 {Name}\n" +
            $"Age:                  {Age}\n" +
            $"Gender                {Gender}\n" +
            $"Driver License:       {DriverLicense}\n" +
            $"Driving Experience:   {DrivingExperience}");
    }

}
