// 1. Выводим сообщение пользователю на ввод числа
Console.Write("Введите число: ");

/* 2. Считываем введенные пользователем символы 
и сохраняем их в строковую переменную UserInputStr */

string UserInputString = Console.ReadLine() ?? "";

/* !!! Переменная userInputString сейчас строковая (string).
* она не может участвовать в математических операциях!
* Для этого ее необходимо преобразовать в требуемый численный тип (int, double и пр.)
*/ 

// 3. Создаем локальную переменную типа double для хранения числа.

Double userInputDouble;

/* 4. Выполняем преобразование строковой переменной UserInputString 
в числовую UserInputDouble.
В случае успеха, выводим в консоль число умноженное на само себя */
if (double.TryParse(UserInputString, out userInputDouble))
{
    Console.WriteLine(userInputDouble*userInputDouble);
}
else // Иначе (т.е. если не удалось преобразовать строку в число - сообщение об ошибке)
{
    Console.WriteLine("Ошибка ввода! Введите число!");
}