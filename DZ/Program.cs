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
    else { break; }
}

string[] array = Array(size);
Console.WriteLine($"[{string.Join(", ", array)}]");



string[] Array(int sizeStrw)
{
    string[] arr = new string[sizeStrw];

    for (int i = 0; i < sizeStrw; i++)
    {
        Console.Write("Введите слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void Format()
{
    string[] arrFormat = new string[size];
    for (int i = 0; i < size; i++)
    {
        
        Console.WriteLine(array[i].Length);
        /* if (num.Length <= 3)
        {
            Console.WriteLine("Петух");
        }
        else{
            Console.WriteLine("Петух2");
        } */
        
    }
}

Format();

Console.ReadLine();
