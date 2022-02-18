// Выяснить является ли число чётным


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    Console.WriteLine("Введенное число {0} четное ", number);
}
else
{
    Console.WriteLine("Введенное число {0} не четное ", number);

}


