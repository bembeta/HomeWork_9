/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Ввидете значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидете значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if(n==m)return m;
    return n + SumNumbers(m, n - 1);   
}
Console.WriteLine($"M = {m}; N = {n}; -> {SumNumbers(m, n)}");