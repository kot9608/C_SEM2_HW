// Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int num2 = int.Parse(Console.ReadLine());
int kv1=num1*num1;
int kv2=num2*num2;
if (kv1==num2 || kv2==num1){
  Console.WriteLine("Да");
}
else  {
  Console.WriteLine("Нет");
}