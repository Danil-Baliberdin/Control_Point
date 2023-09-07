// из массива строк оставить только те строки что содежат 3 символа или меньше

string[] array = new string[10];

string InfoForArray(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine()!;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = InfoForArray($"введите {i + 1} значение - ");
}

int newArraySize = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        newArraySize = newArraySize + 1;
    }
}

string[] NewArrayFiller(string[] OldArray, int Size)
{
    string[] Array = new string[Size];
    int count = 0;
    for (int i = 0; i < OldArray.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            Array[count] = OldArray[i];
            count++;
        }
    }
    return Array;
}




string[] newArray = NewArrayFiller(array, newArraySize);

void PrintArray(string[] array)
{
    Console.Write("NewArray - ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

PrintArray(newArray);

