//напишите программу, которая на вход принимает число и выдает количество цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countOfFigures = CountOfFigures(number);

//Method
int CountOfFigures (int num)
{
    int count = 0;
    while(num > count)
    {
        num = num/10;
        count ++;
    }
    return count;
}
Console.WriteLine($"количество цифр в числе {number} -> {countOfFigures}");

