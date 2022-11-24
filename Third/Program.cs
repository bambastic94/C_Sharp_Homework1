// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Tape number ");
string A = Console.ReadLine();
int Number = Convert.ToInt32(A);

if (Number % 2 == 0) Console.WriteLine($"{Number} is an even number");

else Console.WriteLine($"{Number} is an odd number");