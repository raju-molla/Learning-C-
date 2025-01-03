using System;
class Test{
    public static void Main(String[] args) {

      int number;
      Console.WriteLine("Enter a number between 1 to 10");
      number = Convert.ToInt32(Console.ReadLine());
      string message = number switch{
         int num when num < 1 || num > 10 => "number is out of range",
         int num when num%2==0 => "Even",
         int num when num%2!=0 => "odd",
         _ => "default"

      };
      Console.WriteLine(message);


    }
}