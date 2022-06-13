/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*int n = Input("Введите число: ");
int i =1;
int result =1;
string number=" "
while(n>=i)
{
    result=Quadro(int i);
    number=number + Convert.ToString(result);
    i++;
}
Console.WriteLine(number);
int Quadro(int a)
{
    return a * a;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
Console.Write(result);
*/

/*int n = Input("Введите число: ");
int i =1;
int result = 1;
string number ="";
while(n>=i)
{
    result= Quadro(i);
    number = (number + Convert.ToString(result));
    i++;
}
Console.WriteLine(number);

int Quadro(int a)
{
    return a * a;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*int n = Input("Введите число: ");
int i =1;
int result = 1;
string number ="";
while(n>=i)
{
    result= Quadro(i);
    number = number + "," +Convert.ToString(result);
    i++;
}
Console.WriteLine(number);

int Quadro(int a)
{
    return a * a;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/* Вариант от Дениса
*/
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    int result = Quadro(count);
    count = count + 1;
    Console.Write($"{result}, ");
}


int Quadro (int a)
{
    return a * a;
}
