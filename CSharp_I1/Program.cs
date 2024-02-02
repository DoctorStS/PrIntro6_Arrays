/* Задача 1: Задайте двумерный массив символов (тип char [,]).
Создать строку из символов этого массива.*/

Console.OutputEncoding = System.Text.Encoding.ASCII; //Чтобы не писала белиберду
Console.Clear();

const byte X = 20;
const byte Y = 20;

/// Генерация случайного символа
char RandomCharGen ()
{
    Random random = new Random();
    char rndChar = (char)random.Next(' ', '~'+1);
    return rndChar;
}

/// Заполнение массива случайных символов
char [,] CreateCharsTable (int X, int Y)
{
    char[,] chars = new char[X,Y];
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            chars[i,j] = RandomCharGen();
        }
    }
    return chars;
}

/// Получение строки из массива символов
string GetStringFromCharArray (char [,] arr)
{
    string result = string.Empty;
    foreach (char symb in arr)
    {
        result += symb;
    }
    return result;
}

Console.WriteLine(string.Join("", GetStringFromCharArray(CreateCharsTable(X,Y))));

