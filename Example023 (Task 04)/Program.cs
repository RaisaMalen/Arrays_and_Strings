// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
//В полученной строке слова должны быть также разделены пробелами.

string phrase = "The winter is comming";
string [] words = phrase.Split (new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
foreach (string elem in words){
    if (elem != " "){
    for (int i = words.Length; i > 0; i--){
        Console.Write (words [i-1] + " ");
        }
    }
    break;
}