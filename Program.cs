// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void showNumbers (int num)
{
    Console.Write(num + " ");
    if(num > 1) showNumbers(num - 1);
}

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
while(n <= 1)
{
    Console.WriteLine("Число n должно быть больше единицы. Введите число снова:");
    n = Convert.ToInt32(Console.ReadLine());
}
showNumbers(n);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int Sum (int num1, int num2)
{
    if(num1 <= num2) return Sum(num1 + 1, num2) + num1;
    else return 0;
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
while(m < 1)
{
    Console.WriteLine("Число m должно быть больше нуля. Введите число снова:");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1 || n == m || n < m)
{
    Console.WriteLine("Число n должно быть больше нуля, больше числа m и не должно быть равно числу m. Введите число снова:");
    n = Convert.ToInt32(Console.ReadLine());
}

int sum = Sum(m, n);
Console.Write($"Сумма чисел от {m} до {n} равна: {sum}");
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1)
{
    Console.WriteLine("Число n должно быть больше нуля. Введите число снова:");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
while(m < 1)
{
    Console.WriteLine("Число m должно быть больше нуля. Введите число снова:");
    m = Convert.ToInt32(Console.ReadLine());
}

int A = Akkerman(n, m);
Console.WriteLine("\nЗначение функции Аккермана при заданных значениях: " + A);
*/