// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

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

int SumNumbers(int value)
{
 int result = 0;
  
  while (value >= 1)
  {
    result = result + (value % 10);
    value = value  / 10;
  }

  return result;

}

int value = InputInt ("Введите число - > ");

int result = SumNumbers (value);

System.Console.WriteLine($"Сумма цифр числа {value} = {result}");