// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Tape first number ");
string A = Console.ReadLine();
int One = Convert.ToInt32(A);

Console.Write("Tape second number ");
string B = Console.ReadLine();
int Two = Convert.ToInt32(B);

Console.Write("Tape third number ");
string C = Console.ReadLine();
int Three = Convert.ToInt32(C);

if (One == Two & Two == Three)
{
    Console.WriteLine("These numbers are the same");
}
else if (One >= Two)
{
    if (One >= Three)
    {
        Console.WriteLine(One + " is maximal number");
    }
    else
    {
        Console.WriteLine(Three + " is maximal number");
    }
}
else
{
    if (Two >= Three)
    {
        Console.WriteLine(Two + " is maximal number");
    }
    else
    {
        Console.WriteLine(Three + " is maximal number");
    }
}