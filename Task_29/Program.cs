// Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задайте размер массива");
int num = int.Parse(Console.ReadLine());
int[] arr = new int[num];

CreateArray(arr);
PrintArray(arr);


int[] CreateArray(int[] array)
{
    int count = array.Length;
    Console.WriteLine($"Введите {count} целых числа/чисел:");
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int[] PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("Массив целых чисел - ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
