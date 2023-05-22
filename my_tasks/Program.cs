int result = 1;
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Произведение чисел ");
for(int i = 1; i <= num; i++)
{
    result = i * result;
    if (i == num) Console.Write($"{i}");
    else Console.Write($"{i}*");
}
Console.WriteLine($" равно {result}");