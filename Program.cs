/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
['hello", "2", "world", ":-)"] -> ["2", "-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

int NewArraySize(string[] array, int maxLengthLines)         // узнаю размер нового массива, который в дальнейшем будем заполнять
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLengthLines)
            count++;
    }

    return count;
}

string[] SortedArray(string[] array, int maxLengthLines, int size)     // помещаю в новый массив строки с количеством элементов <= 3 !
{
    string[] newArr = new string[size];
    int index = 0;
    int j = 0;
    while (index < array.Length)
        if (array[index].Length <= maxLengthLines)
        {
            newArr[j] = array[index];
            index++;
            j++;
        }
        else
        {
            index++;
        }
    return newArr;
}

void PrintArray(string[] array)         // печатаю массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите значение {i} элемента: ");
    string element = Console.ReadLine()!;
    array[i] = element;
}
int maxLength = 3;
int newArraySize = NewArraySize(array, maxLength);
PrintArray(array);
string[] sortedArr = SortedArray(array, maxLength, newArraySize);
Console.Write(" -> ");
PrintArray(sortedArr);
