// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
Console.WriteLine("Введите длину массива");
int num = InputInt();
int[] arr = GetArray(num);
PrintArray(arr);



void PrintArray (int [] array)
{
    for(int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}



int [] GetArray (int userLangth)
{
    int[] array = new int[userLangth];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,2);
    }
    return array;
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