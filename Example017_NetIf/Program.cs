// Как избавиться от множественной вложенности оператора if?
Console.Write("Введите первое число: ");
string number_1s = Console.ReadLine() ?? "";
int number_1i;
Console.Write("Введите второе число: ");
string number_2s = Console.ReadLine() ?? "";
int number_2i;
Console.Write("Введите третье число: ");
string number_3s = Console.ReadLine() ?? "";
int number_3i;
bool isCorrectInput = true;
if ( !int.TryParse(number_1s, out number_1i) ) isCorrectInput = false;
if ( !int.TryParse(number_2s, out number_2i) ) isCorrectInput = false;
if ( !int.TryParse(number_3s, out number_3i) ) isCorrectInput = false;
if(!isCorrectInput)
{
    Console.WriteLine("Выявлены ошибки при вводе данных!");
    return;
}
int max = 0;
if (number_1i > max) max = number_1i;
if (number_2i > max) max = number_2i;
if (number_3i > max) max = number_3i;
Console.Write($"Максимальное число: {max}");
