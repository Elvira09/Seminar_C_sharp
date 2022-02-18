// Проверить истинность утверждения ¬ (X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = false;

if(!(x | y) == !x & !y)
{
    Console.WriteLine("Истина");
}
else
{
    Console.WriteLine("Ложь");

}