using Exercise_01;

Console.WriteLine("--- Home Work 5. Exercise 2 ---\n");

var person = new Person("Zagir", 39);
var personClone = person.Clone();

personClone.Name = "Zaliya";
personClone.Age = 31;

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
Console.WriteLine($"Name: {personClone.Name}, Age: {personClone.Age}");
