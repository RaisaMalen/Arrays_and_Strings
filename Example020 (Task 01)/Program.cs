// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromCharArray (char [,] chars){
    string array = "";
    foreach (char elem in chars) {
        array += elem;
        }
        return array;
        }

char [,] chars = {
    {'o', 'n', 'd', 'w'},
    {'j', 'c', 'k', 'l'},
    {'s', 'x', 'h', 'p'}
};

string row = GetStringFromCharArray(chars);
Console.WriteLine(row);
