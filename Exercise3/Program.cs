Console.Clear();
Console.WriteLine("Эта программа для проверки четности введенного числа");
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine(a + " является четным числом");
}
else
{
    Console.WriteLine(a + " является нечетным числом");
}