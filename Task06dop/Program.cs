/*Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7
*/

Console.WriteLine("Введите число для нахождения его модуля: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A > 0){
    Console.WriteLine(A);
}
else{
    Console.WriteLine(-A);
}