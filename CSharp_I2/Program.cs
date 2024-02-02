using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        /* Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
        Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/

        Console.OutputEncoding = System.Text.Encoding.ASCII;
        Console.Clear();

        const byte X = 20;
        const byte Y = 20;

        Console.WriteLine(string.Join("", GetStringFromLetterArray(CreateLettersTable(X,Y))));      
    }

    /// Генерация случайной буквы
    static char RandomLetterGen ()
    {
        // диапазон больших и малых лат букв
        byte minIncludedAscii = 65; // A
        byte maxIncludedAscii = 122; // z
        // убираем промежуточные символы
        byte minExcludedAscii = 91; // [
        byte maxExcludedAscii = 97; // ` + 1 = a
        int excludedLength = maxExcludedAscii-minExcludedAscii;
        int[] excludeValues = new int[excludedLength];
        for (int i = 0; i < excludedLength-1; i++)
        {
            excludeValues[i] = minExcludedAscii + i;
        }
        Random random = new Random();
        
        int rndAsciiLetter = Enumerable
        .Range(minIncludedAscii, maxIncludedAscii - minIncludedAscii + 1)
        .Except(excludeValues).OrderBy(x => random.Next()).FirstOrDefault();
        char rndLetter = (char)rndAsciiLetter;
        return rndLetter;
    }

    /// Заполнение массива случайных букав
    static char [,] CreateLettersTable (byte X, byte Y)
    {
        char[,] letters = new char[X,Y];
        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                letters[i,j] = RandomLetterGen();
            }
        }
        return letters;
    }

    /// Получение строки из массива букв и опускание регистра
    static string GetStringFromLetterArray (char [,] arr)
    {
        string result = string.Empty;
        foreach (char symb in arr)
        {
            result += symb;
        }
        return result.ToLower();
    }
}

