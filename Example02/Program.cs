// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4->24 5->120
Console.Clear();

Console.WriteLine("Введите число");
int number = InputInt();
double result = GetMultiNum(number);
Console.WriteLine(result);

double GetMultiNum(int num)
{
    double multi = 1;
    for (int i = 1; i <= num; i++)
    {
        multi = i * multi;
    }
    return multi;
}


int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed)
    {
        Console.WriteLine("Incorrect data");
        return 0;
    }
    return num;
}