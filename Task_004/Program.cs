// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string input()
{
    Console.WriteLine("Введите строку(используя латиницу):");
    return Console.ReadLine()!;
}

string[] reverse(string str)
{
    int count = 0;
    int j = 0;
    string a = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            count += 1;
        }
    }
    count = count * 2 + 1;
    string[] output = new string[count];
    string[] output1 = new string[count];

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
        {
            a += str[i];
        }
        else
        {
            output[j] = a;
            output[j + 1] = " ";
            j += 2;
            a = "";
        }
    }
    output[j] = a;
    for (int i = 0; i < output.Length; i++)
    {
        output1[i] = output[output.Length - 1 - i];
    }
    return output1;
}
Console.WriteLine(String.Join("", reverse(input())));