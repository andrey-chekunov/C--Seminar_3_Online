/*int x = Input("Введите координату х: ");
int y = Input("Введите координату y: ");
if (x == 0 || y == 0)
{
    Console.WriteLine("Х и У не могут быть равны 0");
    return;
}
if (x > 0 && y > 00)
{
    Console.WriteLine("1я четверть");
}
if (x<0 && y>0)
{
    Console.WriteLine("2я четверть");
}
if (x<0 && y<0)
{
    Console.WriteLine("3я четверть");
}
if (x>0 && y<0)
{
    Console.WriteLine("4я четверть");
}

int Input(string output);
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
*/

int x = Input("Введите координату x: ");
int y = Input("Введите координату y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("x и y не могут быть равны 0");
    return;
}

if(x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
