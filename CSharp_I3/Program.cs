/* Задача 3: Задайте произвольную строку.
Выясните, является ли она палиндромом.*/

int length = 10;
string str = string.Empty;
//Генератор букв
char RandomCharGen ()
{
    Random random = new Random();
    char rndChar = (char)random.Next('a', 'z'+1);
    return rndChar;
}

// Создание строки, но лучше через StringBuilder .Append
while (str.Length <= length)
{
    str += RandomCharGen();
}
Console.WriteLine(str);

/// Проверка на палиндромность
bool IsPalindrome(string str)
{
    char [] charArray = str.ToCharArray();
    Console.WriteLine("Press 0 for LINQ, press 1 for unLINQ: ");
    string? choice = Console.ReadLine();
    if (choice == "0") // Через функции ЛИНК
        return charArray.SequenceEqual(charArray.Reverse());
    if (choice == "1") // Без ЛИНКов
    {
        for (int i = 0; i < str.Length/2; i++)
        {
            if (str[i] != str[^(i+1)])
                return false;
        }
    }
    return true;
}
Console.WriteLine(IsPalindrome(str));
Console.WriteLine("check " + IsPalindrome("арозаупаланалапуазора"));