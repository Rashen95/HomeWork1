Console.Clear();
Console.WriteLine("Это программа для нахождения максимального числа из трех введенных");
Console.WriteLine("ВАЖНО!!! При необходимости сравнения чисел с плавающей точкой в графу ввода нужно вводить число через запятую");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (a == b && b == c) Console.WriteLine("Все три числа равны!");
else
{
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("Максимальное число равно " + max);
}