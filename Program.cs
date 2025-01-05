using System;

class Person{
    public string name;
    public int age;

    public Person(string setName, int setAge){
        name = setName;
        age = setAge;
    }
    // public void SetValue(string setName, int setAge){
    //     name = setName;
    //     age = setAge;
    // }
    public void Display(){
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Test
{
    public static void Main(String[] args)
    {
        Person p1 = new Person("Raju Molla", 25);
        p1.Display();


        Person p2 = new Person("Rijvi", 30);
        p2.Display();

       

       
    }
}