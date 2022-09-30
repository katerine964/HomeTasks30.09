// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=2; i<=N; i=i+2)
{
    Console.Write(i + " ");
}
