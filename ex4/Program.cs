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

int[]array = new int[8];

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




