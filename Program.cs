/* Задача 22. Напишите программу , которая принимает на вход число (N) и выдает 
таблицу квадратов чисел от 1 до N.  
5 -> 1, 4, 9, 16, 25
2 -> 1, 4  */
int n;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 1; i <= n; i++)
    Console.Write($"{i * i} ");