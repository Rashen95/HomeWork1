Console.Clear();
Console.WriteLine("Это программа для нахождения максимального и минимального числа из двух введенных");
Console.WriteLine("ВАЖНО!!! При необходимости сравнения чисел с плавающей точкой в графу ввода нужно вводить число через запятую");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Первое и второе число равны!");
}
else
{
    if (a > b)
    {
        Console.WriteLine("Первое число больше и равно: " + a);
    }
    else
    {
        Console.WriteLine("Второе число больше и равно: " + b);
    }
}