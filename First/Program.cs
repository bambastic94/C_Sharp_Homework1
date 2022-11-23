// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Tape first number ");
string A = Console.ReadLine();
int One = Convert.ToInt32(A);

Console.Write("Tape second number ");
string B = Console.ReadLine();
int Two = Convert.ToInt32(B);

if (One == Two)
{
    Console.WriteLine("These numbers are the same");
}
else if (One > Two)
{
    Console.WriteLine(One + " is maximal number");
}
else
{
    Console.WriteLine(Two + " is maximal number");
}