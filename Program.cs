// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==b)
{
    Console.WriteLine("числа равны");
}
if (a>b)
{
    Console.WriteLine(a + " наибольшее число " + b + " наименьшее число");
}
if (a<b)
{
    Console.WriteLine(b + " наибольшее число " + a + " наименьшее число");
}
