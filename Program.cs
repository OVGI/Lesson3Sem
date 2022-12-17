/* Задача 17. Напишите программу , которая принимает на вход координаты точки (X и Y), 
причем X не равно 0 и Y не равно нулю и выдает номер четверти плоскости , в котрой 
находится эта точка.  */

int x, y;
Console.Write($"Введите число x: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите число y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0 && y > 0)
    Console.Write($"Координатная плоскость - 1");
if (x < 0 && y > 0)
    Console.Write($"Координатная плоскость - 2");
if (x < 0 && y < 0)
    Console.Write($"Координатная плоскость - 3");
if (x > 0 && y < 0)
    Console.Write($"Координатная плоскость - 4");

