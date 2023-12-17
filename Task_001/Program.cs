// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// char[,] matrix = new char[3, 3];
char[,] mat = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'j' } };

string stringprint(char[,] matrix)
{
    string output = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            output+=matrix[i,j];
        }
    }
    return output;
}
Console.WriteLine(stringprint(mat));