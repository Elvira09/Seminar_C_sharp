// Показать числа от -N до N

Console.WriteLine("Введите отрицательное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выводим числа по порядку от введенного отрицательного до положительного по модулю: "); 
for (int i = number; i <= Math.Abs(number); i++ ) 
{ 
    Console.WriteLine(i); 

}  
/* Вариант решения при совместном решении ДЗ

int a = 110;
int count = a*(-1);
while(count <= a)
{
    Console.WriteLine(count);
    count ++;
}
*/