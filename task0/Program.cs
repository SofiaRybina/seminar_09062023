Console.WriteLine("Input number:");
int number = int.Parse(Console.ReadLine()!); //!убирает предупреждение, но не решает проблему
int result = number * number;
Console.WriteLine("Square number = " + result);