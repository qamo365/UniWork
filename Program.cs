// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter side A:");
string side_A = Console.ReadLine();
Console.WriteLine("Please enter side B:");
string side_B = Console.ReadLine();

double side_A_dub = double.Parse(side_A);
double side_B_dub = double.Parse(side_B);

double side_C = Math.Sqrt(Math.Pow(side_A_dub, 2) + Math.Pow(side_B_dub, 2));

double area = (side_A_dub * side_B_dub) / 2;

Console.WriteLine($"Side C is {side_C:F2}");
Console.WriteLine($"Area is {area:F2}");



