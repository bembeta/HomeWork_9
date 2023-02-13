/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FuncAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FuncAkkerman(m - 1, 1);
    else
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}
Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {FuncAkkerman(m, n)}");