//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 


int[] array = new int[8]; 
int count = 8;
int index = 0;
while (index < count) //заполняем массив случайными числами
    {
        array[index] = new Random().Next(0, 2); 
        index++;        
    }
for (int i = 0; i < count; i++) //пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} "); 
    }


//Вариант с методами

// void FillArray(int[] collection) 
// {
//     int length = collection.Length; 
//     int index = 0; 
//     while (index < length) 
//     {
//         collection[index] = new Random().Next(0, 2); 
//         index++;         

//     }
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length; 

//     for (int i = 0; i < count; i++) 
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);