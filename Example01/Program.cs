// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5
Console.Clear();

Console.WriteLine("Введите число");
int number = InputInt();
int result = GetCountNum(number);
Console.WriteLine($"{number} -> {result}");

int GetCountNum(int num)
{
    int i = 0;
    for (i = 0; num != 0; i++ )
    {
        num = num / 10;
    }
    return i;
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