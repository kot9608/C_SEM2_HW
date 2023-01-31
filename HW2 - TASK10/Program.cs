// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());
if ((num1/100==0) ||(num1/100==10))
  {
  Console.WriteLine ("Введено не трёхзначное число");
  return;
  }
int num2=num1/10;
int result=num2%10;
Console.WriteLine (result);