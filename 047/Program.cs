// Написать программу копирования массива

void PrintArray(int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Дан массив Array со следующими элементами : ");
int[] array = {9, 6, 13, 56, 78};
PrintArray(array);
int[] array1 = array;
Console.WriteLine($"Скопировали данные в массив Array1 : ");
PrintArray(array1);



