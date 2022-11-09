//напишите программу, которая на вход принимает число и выдает количество цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //запросили число и конвертировали его
int countOfFigures = CountOfFigures(number); // применение метода

//Method
int CountOfFigures (int num) //число
{
    int count = 0; //счетчик цифр
    while(num > count) //пока 
    {
        num = num/10;
        count ++;
    }
    return count; //выводим этот показатель потомк что интересует кол-во цифр а не сами цифры
}
Console.WriteLine($"количество цифр в числе {number} -> {countOfFigures}");

