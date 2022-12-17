/* Задача 18. Напишите программу , которая по заданному номеру четверти 
показывает диапазон возможных координат точек в этой четверти (x и y)  */

int a;

Console.Write($"Введите номер четверти координатной плоскости: ");
int.TryParse(Console.ReadLine()!, out a);

if (a == 1)
    Console.Write($"x > 0 y > 0");
else if (a == 2)
    Console.Write($"x < 0 y > 0");
else if (a == 3)
    Console.Write($"x < 0 y < 0");
else if (a == 4)
    Console.Write($"x > 0 y < 0");
else
    Console.Write($"Неверный ввод");
