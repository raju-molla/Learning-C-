using System;


class Student
{

    public string Name
    {
        get;
        private set;
    }
    public DateTime DateOfBirth
    {
        get;
        set;
    }
    public string RollNumber
    {
        get;
        set;
    }
    public Student(string studentName, DateTime studentDateOfBirth, string studentRollNumber)
    {
       ValidInputDate(studentName, studentDateOfBirth, studentRollNumber);
        Name = studentName;
        DateOfBirth = studentDateOfBirth;
        RollNumber = studentRollNumber;
    }
    private static void ValidInputDate(string studentName, DateTime studentDateOfBirth, string studentRollNumber){
         if(string.IsNullOrEmpty(studentName)){
            throw new ArgumentException("Student name cannot be null or empty");
        }
        if(string.IsNullOrEmpty(studentRollNumber)){
            throw new ArgumentException("Roll number cannot be null or empty");
        }
        if(studentDateOfBirth == default){
            throw new Exception("Date of birth can not be null");
        }
        if(DateTime.Now < studentDateOfBirth){
            throw new Exception("Student's date of birth is in the future");
        }
    }

    private int CalculateAge(){
     int age = DateTime.Now.Year - DateOfBirth.Year;
     if(DateTime.Now.DayOfYear < DateOfBirth.DayOfYear){
        age--;
     }
     return age;
    }
    public int Age => CalculateAge();
    public void DisplayDetails(){
        Console.WriteLine($"Name: {Name}\nDate of birth: {DateOfBirth.ToShortDateString()}\nRoll number: {RollNumber}\nAge: {Age}");

    }
}
class Test1
{
    public static void Main1(String[] args)
    {
        try
        {
            Student studentOne = new Student("Raju Molla",new DateTime(2000, 3, 10),"56");

            Student studentTwo = new Student("Rijvi",new DateTime(1999, 10, 3), "18");

            Console.WriteLine("\tStudent One:------------------------- ");
            studentOne.DisplayDetails();
            Console.WriteLine("\tStudent Two:--------------------------");
            studentTwo.DisplayDetails();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}