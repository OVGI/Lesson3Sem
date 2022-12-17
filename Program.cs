/* Задача 20. Напишите программу , которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.  
 A (3,6); B (2,1) - > 5,09
 A (7, -5); B (1, -1) - > 7,21     */
int xa, xb, ya, yb;

Console.Write($"Введите координату X точки A: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Введите координату Y точки A: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Введите координату X точки B: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Введите координату Y точки B: ");
int.TryParse(Console.ReadLine()!, out yb);

int x = (xa - xb) * (xa - xb);
int y = (ya - yb) * (ya - yb);

double ans = Math.Sqrt(x + y);
Console.Write($"Расстояние между точками A и B = {Math.Round(ans, 2)}");