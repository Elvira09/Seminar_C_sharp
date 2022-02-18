// Выяснить являются ли три числа сторонами треугольника
// используем неравенство треугольника a<=(b + c) & b<=(a+c) & c<=(a+b)

Console.WriteLine("Введите длину первой стороны треугольника: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a<=(b + c) & b<=(a+c) & c<=(a+b))
{
	Console.WriteLine($"Введенные значения {a}, {b}, {c} - являются сторонами треугольника: ");
}
else
{
	Console.WriteLine($"Введенные значения {a}, {b}, {c} - не являются сторонами треугольника: ");

}