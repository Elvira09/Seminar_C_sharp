//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = number  %  10;
int result2 = (number  % 1000) / 100;
Console.WriteLine("После удаления второй цифры числа получился следующий результат: " + result2 + result1);

