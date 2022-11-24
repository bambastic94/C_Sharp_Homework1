// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 2;

Console.Write("Tape number ");
string A = Console.ReadLine();
int Number = Convert.ToInt32(A);

if (Number <= 1) 
{
    Console.WriteLine("There's nothing to show");
}

else 
{
    while (N <= Number)
    {
        Console.Write($"{N} ");
        N = N + 2;
    }
}
