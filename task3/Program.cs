
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int InputInt(string message)
{
    System.Console.Write(message);
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);

    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] FillArray(int sizeArray, int minUnit, int maxUnit)
{
    int[] array = new int[sizeArray];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minUnit, maxUnit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     //   System.Threading.Thread.Sleep(50);
        System.Console.Write($"{array[i]} ");
    }
}

int sizeArray = InputInt("Задайте размер массива > ");
int minUnit = InputInt("Задайте минимальное значение элементов массива > ");
int maxUnit = InputInt("Задайте максимальное значение элементов массива > ");
int[] array = FillArray(sizeArray, minUnit, maxUnit);
PrintArray(array);

