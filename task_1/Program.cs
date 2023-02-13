/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Ввидите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int Recyrc(int n, int a)
{
    if(n == a) 
        return n;
    else
        Console.Write($"{Recyrc(n, a + 1)} ");
        return a;
}
Recyrc(n, a);
