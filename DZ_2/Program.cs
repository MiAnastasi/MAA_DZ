// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Ввведите число №1: ");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());

Console.Write("Ввведите число №2: ");
int secondNumber = Convert.ToInt32 (Console.ReadLine ());

Console.Write("Ввведите число №3: ");
int thirdNumber = Convert.ToInt32 (Console.ReadLine ());

int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
}
else 
{
    max = secondNumber;
}

if (max > thirdNumber)
{
    Console.WriteLine("max = " + max);
}
else 
{
    Console.WriteLine("max = " + thirdNumber);
}