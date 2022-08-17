//Вид 1: Ничего не возвращают ничего не принимают
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Вызов метода через:
//Method1();
//Вид2: Ничего не возвращают, но принимают какие-то аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Вызов метода
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
//Вид3: Методы которые что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид4 Методы, которые что-то принимают и что-то возвращают.
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res =  Method4(10, "qwerty");
Console.WriteLine(res);
//4 метод покороче
string Method41(int count, string text)
{
    
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res1 =  Method41(10, "z");
Console.WriteLine(res1);

//Пример цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
    Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
