/* Задача 1. Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее
*/

Console.WriteLine("Введите первое число для сравнения: ");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для сравнения: ");

int B = Convert.ToInt32(Console.ReadLine());

if (A > B){
    Console.Write("Большее число: ");
    Console.WriteLine(A);
    Console.Write("Меньшее число: ");
    Console.WriteLine(B);

}
else{
    Console.Write("Большее число: ");
    Console.WriteLine(B);
    Console.Write("Меньшее число: ");
    Console.WriteLine(A); 
} 