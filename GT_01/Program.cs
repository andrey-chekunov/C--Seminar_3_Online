//*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ch = Input("Введите четверть: ");
if (ch == 1)
{
    Console.WriteLine($"x=0...{int.MaxValue}, y=0...{int.MaxValue} ");
}
else if (ch == 2)
{
    Console.WriteLine($"x={int.MinValue}...0, y=0...{int.MaxValue} ");
}
else if (ch == 3)
{
    Console.WriteLine($"x={int.MinValue}...0, y={int.MinValue}...0 ");
}
else if (ch == 4)
{
    Console.WriteLine($"x=0...{int.MaxValue}, y={int.MinValue}...0 ");
}
else
{
    Console.WriteLine("Нет такой четверти");
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/* Второй вариант(другая комната)
Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("По х: от 0 до + бесконечности");
    Console.WriteLine("По y: от 0 до + бесконечности");
}
if (number == 2)
{
    Console.WriteLine("По х: от - бесконечности до 0");
    Console.WriteLine("По y: от 0 до + бесконечности");
}
if (number == 3)
{
    Console.WriteLine("По х: от - бесконечности до 0");
    Console.WriteLine("По y: от - бесконечности до 0");
}
if (number == 4)
{
    Console.WriteLine("По х: от 0 до бесконечности");
    Console.WriteLine("По y: от - бесконечности до 0");
}
*/