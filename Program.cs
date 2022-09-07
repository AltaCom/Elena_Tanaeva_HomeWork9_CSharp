/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""

void NaturalNumber(int m, int n)
{  
if (m < n && m != n) 
{
    NaturalNumber(m, n - 1);
    Console.Write(n + " ");    
}
else 
{
    if (n < m && m != n)
    NaturalNumber(m - 1, n);
    Console.Write(m + " ");    
}
}
Console.WriteLine();
Console.Write("Input M: ");
int num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int num2  = Convert.ToInt32(Console.ReadLine());
NaturalNumber(num1, num2);
Console.WriteLine();
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SumOfNumbers (int n, int m)
{ 
if (m < n && m != n) return n + SumOfNumbers(n-1, m);
else 
{
if (n < m && m != n) return m + SumOfNumbers(n, m-1);
}
return m;  
}

Console.WriteLine();
Console.Write("Input M: ");
int num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int num2  = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(num1, num2);
Console.Write($"The sum of numbers between {num1} and {num2} is {result}");
Console.WriteLine();
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29

int AFunction (int n, int m)
{
if (n == 0) return m+1;
else
if (n != 0 && m == 0) return AFunction(n - 1, 1);
else
if (n > 0 && m > 0) return AFunction(n - 1, AFunction(n, m - 1));
return 0;
}
Console.WriteLine();
Console.Write("Input M: ");
int num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int num2  = Convert.ToInt32(Console.ReadLine());
int result = AFunction(num1, num2);
Console.Write($"The Akkerman function is equal {result}");
Console.WriteLine();
*/