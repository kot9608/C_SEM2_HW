// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1<1 || num1>7)
  {
  Console.WriteLine ("Введён некорректный день недели");
  return;
  }
else if (num1<6) {
  Console.WriteLine("Нет");
}
else  {
  Console.WriteLine("Да");
}
