// Написать программу возведения числа А в целую степень B

long NumberToThePower (int number, int power)
{
	if (power == 1) return number;
    else return number * NumberToThePower(number, power - 1);
}

Console.WriteLine(NumberToThePower(2, 8));

