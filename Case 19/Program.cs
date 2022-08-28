// // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Reverse()
{
Console.WriteLine("Введите целое пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int a = 10000;
int y = N;
int result = 0;
while (i < 5) 
{
result += y%10 * a;
a = a/10;
y = y/10;
i++;
}
if (result == N)
{
Console.WriteLine("Да, введённое число является палиндромом");
}
else Console.WriteLine("Нет, введённое число не является палиндромом ");
}
Reverse();