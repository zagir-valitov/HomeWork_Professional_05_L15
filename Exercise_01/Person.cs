namespace Exercise_01;

public class Person : IMyCloneable<Person>
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string? name, int age)
    {
        Name = name;
        Age = age;        
    }
    public Person Clone()
    {
        return new Person(Name, Age);
    }
}
