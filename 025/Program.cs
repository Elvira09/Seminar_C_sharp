// Найти сумму чисел от 1 до А

// Вариант 1 - большие числа не отрабатываются

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int summ = 0;
//for (int i = 0; i <= number; i++)
// {
//     summ = summ + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number} составляет: {summ}");

// Вариант 2 - все работает
// Console.WriteLine("Введите число: ");
// long number = Convert.ToInt64(Console.ReadLine());
// long summ = 0;
// for (long i = 0; i <= number; i++)
// {
//     summ = summ + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number} составляет: {summ}");

// Вариант 3 - проверяем время работы второго варианта
// Console.WriteLine("Введите число: ");
// long number = Convert.ToInt64(Console.ReadLine());
// DateTime dt = DateTime.Now; // текущее время
// long summ = 0;
// for (long i = 0; i <= number; i++)
// {
//     summ = summ + i;
// }
// Console.WriteLine($"Время обработки кода {(DateTime.Now-dt).TotalSeconds} секунд");//выводим время обработки кода
// Console.WriteLine($"Сумма чисел от 1 до {number} составляет: {summ}");

// Вариант 4 - вычисляем с помощью арифметической прогрессии
Console.WriteLine("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
//DateTime dt = DateTime.Now; // текущее время
long summ = number * (number + 1) / 2;
//Console.WriteLine($"Время обработки кода {(DateTime.Now-dt).TotalSeconds} секунд");//выводим время обработки кода
Console.WriteLine($"Сумма чисел от 1 до {number} составляет: {summ}");

