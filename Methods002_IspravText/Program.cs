/* Работа с текстом
Дан текст, нужно: 
1) все пробелы заменить черточками
2) маленькие буквы к заменить на большие буквы К
3) больше С заменить на маленькие с */

// Ясна ли задача?

String text = "Я думаю,- сказал князь, улыбаясь - что,"
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + " Вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] => возьмем r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);