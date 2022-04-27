/* Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Введите перводе число для сравнения: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для сравнения: ");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число для сравнения: ");

int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max > number2){
    if (max > number3)
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);
    }
    else
    {
        max = number3;
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);

    }
}
else{
    max = number2;
    if (max > number3)
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);
    }
    else
    {
        max = number3;
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);

    }
};
