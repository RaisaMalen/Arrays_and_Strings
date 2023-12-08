// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string row = "The Winter Is Comming";
string ChangeRegister (string row){
    string res = row.ToLower();
    return res;
}
ChangeRegister (row);
Console.WriteLine (ChangeRegister (row));