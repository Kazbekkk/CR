# Решение задачи

1. Обьявление переменных: ``` string sizeStr; int size;```;
2. Задаем размер массива (через ввод) и делаем проверку на ввод: 
``` c# Console.Write("Задайте размер массива: ");
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
```
3. Создаем метод в котором формирует массив. Ввод данных в масив будет в ручную
``` c# string[] Array(int sizeStrw) // создание массива
{
    string[] arr = new string[sizeStrw];

    for (int i = 0; i < sizeStrw; i++)
    {
        Console.Write("Введите слово: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
```

4. Полученный массив присваиваем и выводим.
``` c# 
string[] array = Array(size);
Console.WriteLine($"[{string.Join(", ", array)}]");
```
5. Создаем метод который из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
**Перым** делом подсчитываем количесвто строк которые меньше либо равны трем символам (нужно чтобы задать размер нового массива). **Второе** делаем проверку и записыем значения в новый массив
``` c#
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
    Console.WriteLine($"[{string.Join(", ", arrFormat)}]");
}

Format();
```



