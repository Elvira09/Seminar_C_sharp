//Показать четные числа от 1 до N


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа: ");

for(int i=1; i<=number; i++) 
{
    if(i%2 == 0) 
    {
    Console.WriteLine(i);
    }
}
  
     