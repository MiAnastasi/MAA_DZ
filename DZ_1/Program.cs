// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Ввведите число №1: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());

Console.Write("Ввведите число №2: ");
int secondNumber = Convert.ToInt32 (Console.ReadLine ());

if (firstNumber > secondNumber)
{
    Console.WriteLine("max = " + firstNumber);
   
}

else 
{
    Console.WriteLine("max = " + secondNumber);
}