//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Данные для проверки работоспособности:
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Решение задачи 19:
/*
void CheckNumPalindrome(int num)
{
    int num_1 = num / 10000;
    int num_2 = num / 1000;
    num_2 = num_2 % 10;
    int num_4 = num % 100;
    num_4 = num_4 / 10;
    int num_5 = num % 10;
    if(num_1 == num_5 & num_2 == num_4) Console.WriteLine($"Число {num} является палиндромом!");
    else Console.WriteLine($"Число {num} палиндромом не является");  
}
Console.Write("Введите 5-ти значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 10000 || num > 100000) Console.WriteLine("Упс... вы задали не 5-ти значное число!");
else CheckNumPalindrome(num);
*/
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Данные для проверки работоспособности:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула для решения:
//AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2
// Решение задачи 21:
/*
double Distance(int xa, int xb, int ya, int yb, int za, int zb)
{
    double ab = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
    return ab;
}
Console.Write("Введите координату xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату za: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Расстояние между точками ({n1}, {n2}), ({n3}, {n4}) и ({n5}, {n6})  равно {Distance(n1, n2, n3, n4, n5, n6)}");
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Данные для проверки работоспособности:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Решение задачи 23:
/*
void CubeNum(int num)
{
    for(int i=1; i<=num; i++)
    {
    Console.Write($"{i * i * i} ");
    }
}
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
CubeNum(num);
*/