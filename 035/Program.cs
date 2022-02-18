// Определить, присутствует ли в заданном массиве, некоторое число

void PrintArray(int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length; 
    int index = 0; 
    int position = -1; 
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            
        }
        index++;
    }
    return position;
}

// Вариант 1
Console.WriteLine($"Дан массив со следующими элементами : ");
int[] array = {347, 34, 24, 789, 123, 5, 96,};
PrintArray(array);


// int find = 123;
// Console.WriteLine($"Необходимо найти элемент со значением {find}"); 

Console.WriteLine($"Введите элемент, который необходимо найти: "); 
int find = Convert.ToInt32(Console.ReadLine());
int pos = IndexOf(array, find);
Console.WriteLine($"Искомый элемент под индексом {pos}"); 


// Вариант 2 - НУЖНО ДОРАБОТАТЬ ВЫВОД - убрать дублирование выводов при при прогонке цикла
 
// Console.WriteLine($"Дан массив со следующими элементами : ");
// int[] array = {347, 34, 24, 789, 123, 5, 96,};
// PrintArray(array);
// Console.WriteLine($"Введите элемент, который необходимо найти: "); 
// int find = Convert.ToInt32(Console.ReadLine());
// int count = array.Length;
// int index = 0;
// int pos = 0;

// while(index < count)
// {
//     if(array[index] == find)
//     {
//        pos = index;
//        Console.WriteLine($"Искомый элемент под индексом {pos}");
//        break;
//     }
//     else
//     {
//       Console.WriteLine($"Искомый элемент не найден");
//     }
    
//     index++;
// }


