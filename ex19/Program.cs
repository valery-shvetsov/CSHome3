//проверка числа полиндром или нет

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}
string PolyTest(int number)
{
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
    {
        return ("Число полиндром");
    }
    else
    {
        return ("Число неполиндром");
    }
}
// основная программа
int number = ReadData("Введите пятизначное число: ");
if (number >= 10000 && number < 100000)
{
    string answer = PolyTest(number);
    PrintData(answer, "");
}
else
{
    PrintData("Число не пятизначное", "");
}




