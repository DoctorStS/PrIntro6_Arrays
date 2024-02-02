/*Задача 4*: Задайте строку, состоящую из слов, разделенных пробелами.
Сформировать строку, в которой слова расположены в обратном порядке.
В полученной строке слова должны быть также разделены пробелами.*/

string str = "hello everybody how are you";

string InvertWords (string str)
{
    //Разбиваем строку на массив подстрок c разделителем 'пробел':
    string[] words = str.Split(' ');
    Array.Reverse(words); // перестановка слов в массиве подстрок
    return string.Join(' ', words); // объединение обратно в строку
}

Console.WriteLine(InvertWords(str));