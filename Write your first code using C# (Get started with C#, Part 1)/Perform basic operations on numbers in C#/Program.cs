// See https://aka.ms/new-console-template for more information
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


// Exercise
int fahrenheit = 94;
decimal fiveNinth = 5m / 9m;

decimal answer;

answer = (fahrenheit - 32) * fiveNinth;

Console.WriteLine($"The temperature is {answer} Celsius.");