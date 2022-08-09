Console.WriteLine("Введите number_A");
string number_As = Console.ReadLine() ??"";
int number_Ai;
Console.WriteLine("Введите number_B");
String number_Bs = Console.ReadLine() ??"";
int number_Bi;
if (int.TryParse(number_As, out number_Ai))
{
    if (int.TryParse(number_Bs, out number_Bi))
    {
        if (number_Ai == number_Bi * number_Bi)
        {
            Console.WriteLine("Число А является квадратом числа В");
        }
        else 
        {
            Console.WriteLine("Число А не является квадратом числа В");
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}