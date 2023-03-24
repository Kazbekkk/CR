// Программа из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

Console.Clear();

string sizeStr;
int size;

Console.Write("Задайте размер массива: ");
sizeStr = Console.ReadLine();

while (true) // проверка на ввод числа
{
    if (!int.TryParse(sizeStr, out size))
    {
        Console.Write("Введите число!: ");
        sizeStr = Console.ReadLine();
    }
    else
    {
        break;
    }
}

string[] array = Array(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

string[] Array(int sizeStrw) // создание массива
{
    string[] arr = new string[sizeStrw];

    for (int i = 0; i < sizeStrw; i++)
    {
        Console.Write("Введите слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void Format() // форматирование
{
    int countArr = 0;

    for (int j = 0; j < size; j++) // счетчик для понимания размера будующего массива
    {
        if (array[j].Length <= 3)
        {
            countArr++;
        }
    }
    string[] arrFormat = new string[countArr]; // создание массива отформатированого

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            arrFormat[count] = array[i];
            count++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", arrFormat)}]");
}

Format();

Console.ReadLine();

