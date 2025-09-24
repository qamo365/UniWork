// See https://aka.ms/new-console-template for more information
double celsius, farenheit, kelvin;
Console.WriteLine("Enter the temperature in degrees:");
celsius = double.Parse(Console.ReadLine());
farenheit = ((celsius * 9) / 5) + 32;
kelvin = celsius + 273;

Console.WriteLine($"{celsius} celsius is {farenheit} farenheit and {kelvin} kelvin");




