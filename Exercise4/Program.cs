Console.Clear();
Console.WriteLine("Эта программа для вывода всех четных чисел от 1 вплоть до введенного в консоль");
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int number = 2;
if (a <= 1)
{
    Console.WriteLine("Введенное число меньше или равно 1!");
}
else
{   
    Console.Write("Все четные числа до введенного включительно: ");
    while (number < a - 1)
    {
        Console.Write(number + ", ");
        number += 2;
    }
Console.WriteLine(number);
}