// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string input()
{
    Console.WriteLine("Введите строку:");
    return Console.ReadLine()!;
}

string check(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i]!=str[str.Length-1-i])
        {
            return "Эта строка - не палиндром";
        }
    }
    return "Эта строка - палиндром";
}

Console.WriteLine(check(input()));