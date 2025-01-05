using System;

class Person{
    public string name;
    public int age;
}
class Test
{
    public static void Main(String[] args)
    {
        Person p1 = new Person();
        p1.name = "Raju Molla";
        p1.age = 25;

        Console.WriteLine($"Name: {p1.name} and Age: {p1.age}");

        Person p2 = new Person();
        p2.name = "Rijvi";
        p2.age = 24;
        Console.WriteLine($"Name: {p2.name} and Age: {p2.age}");

       
    }
}