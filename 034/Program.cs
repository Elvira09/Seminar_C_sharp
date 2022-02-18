// Написать программу замены элементов массива на противоположные


void PrintArray(int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int[] array = { 67, 89, -12, 98, -13, -56 };
Console.WriteLine($"Дан массив со следующими элементами :  ");
PrintArray(array);

Console.WriteLine($"Замена элементов массива на противоположные :  ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
    Console.Write($"{array[i]} "); 
}
