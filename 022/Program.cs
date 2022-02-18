// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты первой точки: ");
Console.WriteLine(" - координата оси X: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" - координата оси Y: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" - координата оси Z: ");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.WriteLine(" - координата оси X: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" - координата оси Y: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" - координата оси Z: ");
double Z2 = Convert.ToDouble(Console.ReadLine());

double result1 = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2));
Console.WriteLine($"Расстояние между точками в пространстве 3D {result1}");

double result2 = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
Console.WriteLine($"Расстояние между точками в пространстве 2D {result2}");

