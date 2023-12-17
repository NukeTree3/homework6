// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string lower(string str)
{
    return str.ToLower();
}
string? srting1 = Console.ReadLine();
Console.WriteLine(lower(srting1!));