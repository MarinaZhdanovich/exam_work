/* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string InputString(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString($"Enter a string {i + 1}: ");  // заполнение массива строками, вводимыми с клавиатуры
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");   //экранированные кавычки
    if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void NewShortStringArray(string[] array)
{
    int count = 0; // количество строк, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] shortArray = CreateArray(count);  //создаем новый массив
    int j = 0; // индекс j для массива shortArray
    for (int i = 0; i < array.Length; i++) // заполнение массива
    {
        if (array[i].Length <= 3)
        {
            shortArray[j] = array[i];
            j++;
        }
    }
    PrintArray(shortArray);
}
int size = InputNum("Enter a size of the array: ");

string[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
Console.Write("→ ");
NewShortStringArray(myArray);