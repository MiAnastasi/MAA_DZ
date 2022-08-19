// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Ввведите число №1: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());
if (firstNumber%2==0)
{
    Console.WriteLine("да");
}

else 
{
    Console.WriteLine("нет");
}