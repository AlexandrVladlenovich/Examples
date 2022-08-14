using System;

class Program {
  public static void Main (string[] args) {
    //Напишите программу, которая выводит случайное число из отрезка [10, 99]
    // и показывает наибольшую цифру числа.
    Console.Clear();
    
    int num = new Random().Next(10, 100);
    int max = GetMaxDigitInTwoDigitNumber(num);
    Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
  }

  public static int GetMaxDigitInTwoDigitNumber(int number)
  {
      int a1 = number / 10;
      int a2 = number % 10;
      int max = a1;
      if (max < a2)
      {
          max = a2;
      }
      return max;
  }
}