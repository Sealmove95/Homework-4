// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int mainNum = Convert.ToInt32(Console.ReadLine());
int sumNumber(int mainNum)
  {  
    int count = Convert.ToString(mainNum).Length;
    int lastNum = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      lastNum = mainNum - mainNum % 10;
      result = result + (mainNum - lastNum);
      mainNum = mainNum / 10;

    }
    return result;
  }
 int sumOfNumber = sumNumber(mainNum);

Console.WriteLine($"{sumOfNumber}");
