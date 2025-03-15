using Exercise_01;

namespace Exercise_00.Parent;

// Класс описывает человека
class Person : IMyCloneable<Person>, ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual Person MyFunctionClone()
    {
        return new Person(Name, Age, Gender);
    }

    public virtual object Clone()
    {
        return new Person(Name, Age, Gender);
    }

    public virtual void GetInformation()
    {
        Console.WriteLine(
            $"\nPerson Information:\n" +
            $"--------------------------\n" +
            $"Name:     {Name}\n" +
            $"Age:      {Age}\n" +
            $"Gender    {Gender}");
    }    
}
