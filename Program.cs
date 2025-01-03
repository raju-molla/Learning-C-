using System;
class Test{
    public static void Main(String[] args) {

    //   Fahrenheit and celsius project 1
    Console.WriteLine("Temperature Converter start:");
    Console.WriteLine("1. Celsius to Fahrenheit");
    Console.WriteLine("2. Fahrenheit to Celsius");
    int choose = Convert.ToInt32(Console.ReadLine());
    switch(choose){
        case 1: 
            Console.WriteLine("Enter celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Fahrenheit is {fahrenheit:F2}");
            break;
        case 2: 
            Console.WriteLine("Enter Fahrenheit:");
            double fahrenheit1 = Convert.ToDouble(Console.ReadLine());
            double celsiusRes = (fahrenheit1 -32)/1.8;
            Console.WriteLine($"Celsius is {celsiusRes:F2}");
            break;
        default:
            Console.Write("Invalid choose\n");
            break;
    }


    }
}