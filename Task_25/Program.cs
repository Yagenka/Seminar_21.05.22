// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B - ");
int numberB = int.Parse(Console.ReadLine());

int numExponent = GetExponent (numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {numExponent}");

int GetExponent (int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)

        result = result * numA;
    return result;
}