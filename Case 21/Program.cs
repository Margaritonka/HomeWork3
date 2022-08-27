// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Res()
{
Console.WriteLine("Введите две координаты x ");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите две координаты y ");
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());
int z1 = x1-y1;
int z2 = x2-y2;
int z3 = x3-y3;
double res = Math.Sqrt(Math.Pow(z1,2)+Math.Pow(z2,2)+Math.Pow(z3,2));
return res;
}
try
{
Console.WriteLine(Res());
}
catch
{
Console.WriteLine("Нужно ввести целые числа ");
}