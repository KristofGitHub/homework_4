// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите целое число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = a;
// Console.WriteLine("Введите целое число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b - 1; i++) {result = a * result;}
// Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {result}");

// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int exit_flag = 0;
// int output = 0;
// int del_1 = 10;
// int del_2 = 1;
// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (exit_flag == 0)
// {
//     if (num % del_1 != num)
//     {
//         int temp = (num % del_1) / del_2;
//         del_1 = del_1 * 10;
//         del_2 = del_2 * 10;
//         output = output + temp;
//     }
//     else 
//     {
//         output = output + (num % del_1) / del_2;
//         exit_flag = 1;
//     }
// }
// Console.WriteLine ($"Сумма цифр введённого вами числа {num} равна {output}");

// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение в ячейке: ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение в ячейке: ");
int max_value = Convert.ToInt32(Console.ReadLine());

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

void PrintArray(int[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

int[] userArray = CreateRandomArray(array_size, min_value, max_value);
PrintArray(userArray);