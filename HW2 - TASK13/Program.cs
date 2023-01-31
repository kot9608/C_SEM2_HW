// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1/100==0)
  {
  Console.WriteLine ("Третьей цифры нет");
  return;
  }
string num1_text = Convert.ToString(num1);
char Result=num1_text[2];

// if ((num1/100==0)
//   {
//   Console.WriteLine ("Третьей цифры нет");
//   return;
//   }
// int num2=num1/10;
// int result=num2%10;
//Console.WriteLine (num1);
Console.WriteLine (Result);