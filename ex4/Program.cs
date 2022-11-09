//напишите программу, которая выводит массив из 8 элементовб заполненный нулями и единицами в случайном порядке

// int[]array = new int[8];

// int[]array = new int[8];

// for(int i = 0; i < array.Length; i++ )
// {
//     array[i] = new Random().Next(0,2); 
//     Console.Write($"{array[i]} ");
// }
// Console.Write(array);

//метод вывода и заполнения массива

//для решения задачи без магических чисел
// Console.Clear();
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine()); 

int[]array = new int[8]; //вместо цифры поставить size

int[] NewArray(int[]arr)
{
    for(int i = 0; i < arr.Length; i++ )
    {
        arr[i] = new Random().Next(0,2); 
        Console.Write($"{arr[i]} ");
    }
return arr;
}
NewArray(array);




