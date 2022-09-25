// Вывод таблицы кубов
int ReadData(string Line)
{
    Console.WriteLine(Line);
    int number = int.Parse(Console.ReadLine()??"");
    return number;
}
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}
string LineNum(int numN, int p)
{
    string outLine = "1";
    for (int i = 2; i<=numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i,p);
    }
    return outLine;
}
//main

int numN=ReadData("Введите число N: ");
string LineTop=LineNum(numN,1);
string LineDoun=LineNum(numN,3);
PrintData("",LineTop);
PrintData("",LineDoun);
