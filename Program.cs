using System;

class Person{
    public string name;
    public int age;
    public void SetValue(string setName, int setAge){
        name = setName;
        age = setAge;
    }
    public void Display(){
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Test
{
    public static void Main(String[] args)
    {
        Person p1 = new Person();
        p1.SetValue("RajuMolla", 25);
        p1.Display();


        Person p2 = new Person();
        p2.SetValue("Rijvi", 30);
        p2.Display();

       

       
    }
}