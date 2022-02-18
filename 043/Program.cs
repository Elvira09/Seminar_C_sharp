// Написать программу преобразования десятичного числа в двоичное

// Вариант 1
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string binary = Convert.ToString(number, 10);
Console.WriteLine($"Перевод десятичного числа {number} в двоичное {binary}");

// Ваоиант 2 с решения ДЗ
// Console.WriteLine("Ведите десятичное число для преобразования его в двоичное");
// int Number = Convert.ToInt32(Console.ReadLine());

// int[] ConvertToBinary(int decimalnumber)
// {
//     int counter = 0;
//     int howLongArr = decimalnumber;
//     while (howLongArr >= 1)
//     {
//         howLongArr = howLongArr / 2;
//         counter++;
//     }
//     int[] arrayBinaryNumber = new int[counter];
//     int dividend = decimalnumber;
//     int fromBackCounter = arrayBinaryNumber.Length - 1;
//     while (dividend >= 1)
//     {
//         arrayBinaryNumber[fromBackCounter] = dividend % 2;
//         dividend = dividend / 2;
//         --fromBackCounter;
//     }
// return arrayBinaryNumber;
// }
// void PrintArray (int[] arraytoprint)
// {
//     for (int i = 0; i < arraytoprint.Length; i++)
//     {
//         Console.Write(arraytoprint[i]);
//     }
// Console.WriteLine();
// }
// PrintArray(ConvertToBinary(Number));