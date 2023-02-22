// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int InputInt(string message)
{
    System.Console.Write(message);
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);

    /// или  if (int.TryParse(Console.ReadLine(), out value))
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int Power(int value1, int value2)
{
    int result = value1;

    for (int i = 1; i < value2; i++)
    {
        result = result  * value1;
    }
    return result;

}

int value1 = InputInt("Введите первое число -> ");
int value2 = InputInt("Введите второе число -> ");

int result = Power(value1,value2);
System.Console.WriteLine($"{value1} в степени {value2} = {result}");