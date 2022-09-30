// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число ");
int C = Convert.ToInt32(Console.ReadLine());
if (A>=B && A>=C)
{
    Console.WriteLine(A+" наибольшее число");
}
else
{
    if (B>=A && B>=C)
    {
        Console.WriteLine(B+" наибольшее число");
    }

    else
    {
        if (C>=A && C>=B)
        {
            Console.WriteLine(C+" наибольшее число");
        }
    }
}

