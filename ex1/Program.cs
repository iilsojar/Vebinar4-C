// напишите программу, которая на вход принимает число А и выдает сумму чисел от 1 до А

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} -> {sumOfNumbers}");

int SumOfNumbers(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num;
        num--;
    }
    return sum;
}


