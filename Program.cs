// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"];
// ["1234", "1567", "-2", "computer science"] -> ["-2"];
// ["Russia", "Denmark", "Kazan"] -> [].
string[] array =Array();
PrintArray(array);
int count =LengthCount(array);

string [] newArr= NewArr(array, count);
PrintArray(newArr);


string[] Array() 
{
    string [] arr = new string [] { "1234", "1567", "-2", "computer science" };
    return arr;
}

int LengthCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count += 1;
    }
    return count;
}
string[] NewArr(string[] array, int length)
{
    string[] newArr = new string[length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
             newArr[j] = array[i];
            j++;
        }
    }
    return  newArr;
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}
