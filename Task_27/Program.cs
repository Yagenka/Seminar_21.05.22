// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());


int GetSum(int num)
{
    int result = 0;
    for (int i = 0; num > 1; i++)
    {

        int numMod = num % 10;
        num = num / 10;
        result = result + numMod;
    }
    return result;
}

int summa = GetSum(number);
Console.WriteLine($"В числе {number} сумма чисел равна {summa}");