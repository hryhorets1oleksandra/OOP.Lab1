// See https://aka.ms/new-console-template for more information
using System;

// 1 завдання

Console.WriteLine();
int number1 = 5;
int number2 = 10;
bool isDay=number2>=1 && number2 <=12;

bool isNight = number1>=1 && number1<=31;
if (isDay && isNight)
{
    Console.WriteLine("Числа можуть бути днем і місяцем.");
}
else
{
    Console.WriteLine("Числа не можуть бути дем і місяцем.");
}


// 2 завдання

Console.WriteLine();
double number = 3.456;

double fraction = Math.Abs(number - Math.Truncate(number));
int firstDigit = (int)(fraction * 10) % 10;
int secondDigit = (int)(fraction * 100) % 10;
int sum = firstDigit + secondDigit;
Console.WriteLine($"{firstDigit}+{secondDigit}={sum}");


// 3 завдання

Console.WriteLine();
int h = 8;
if (h >= 0 && h <= 23)
{
    if (h >= 5 && h < 12)
        Console.WriteLine("Доброго ранку!");
    else if (h >= 12 && h < 18)
        Console.WriteLine("Добрий день!");
    else if (h >= 18 && h < 23)
        Console.WriteLine("Добрий вечір!");
    else
        Console.WriteLine("Доброї ночі!");
}
else
{
    Console.WriteLine("Введено некоректне число.");
}

// 4 завдання

Console.WriteLine();
int a = 3;
int b = 4;
int c = 5;

int max = Math.Max(a, Math.Max(b, c));
int min = Math.Min(a, Math.Min(b, c));
Console.WriteLine(max);
Console.WriteLine(min);

// 5 завдання

Console.WriteLine();
Console.WriteLine("Введіть основу трикутника:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть висоту трикутника:");
double height = double.Parse(Console.ReadLine());
double area = length * height / 2;
Console.WriteLine(area);

// 6 завдання

Console.WriteLine();
int num = 257; 

if (num % 2 == 0)
    Console.WriteLine($"Число {num} парне.");
else
    Console.WriteLine($"Число {num} непарне.");

// 7 завдання


Console.WriteLine();
double celsius = 37.0;

double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

// 8 завдання


Console.WriteLine();
Console.Write("Введіть n: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    int result = n * (n + 1) / 2;
    Console.WriteLine($"Сума перших {n} натуральних чисел: {sum}");
}
else
{
    Console.WriteLine("Введено некоректне число.");
}




