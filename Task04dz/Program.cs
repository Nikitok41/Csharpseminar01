/* Задача 3: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
*/

Console.WriteLine("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = number % 2 == 0;
Console.WriteLine(result ? "четное" : "нечетное");