//напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N
//4->24
//5->120

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //запросили число и конвертировали его

int  multyplyOfNumbers = MultyplyOfNumbers(number); // применение метода

//Method
int MultyplyOfNumbers (int num)
{
    int comp = 1;
    while(num > 1)
    {
        comp = comp * num;
        num --;
    }
    return comp; 
}
Console.WriteLine($"произведение чисел от 1 до {number} -> {multyplyOfNumbers}");


