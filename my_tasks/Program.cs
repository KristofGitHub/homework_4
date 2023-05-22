// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите целое число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = a;
// Console.WriteLine("Введите целое число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b - 1; i++) {result = a * result;}
// Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {result}");

// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int exit_flag = 0;
int output = 0;
int del_1 = 10;
int del_2 = 1;
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (exit_flag == 0)
{
    if (num % del_1 != num)
    {
        int temp = (num % del_1) / del_2;
        del_1 = del_1 * 10;
        del_2 = del_2 * 10;
        output = output + temp;
    }
    else 
    {
        output = output + (num % del_1) / del_2;
        exit_flag = 1;
    }
}
Console.WriteLine ($"Сумма цифр введённого вами числа {num} равна {output}");

// int result = 1;
// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Произведение чисел ");
// for(int i = 1; i <= num; i++)
// {
//     result = i * result;
//     if (i == num) Console.Write($"{i}");
//     else Console.Write($"{i}*");
// }
// Console.WriteLine($" равно {result}");