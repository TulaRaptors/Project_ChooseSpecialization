// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] SortArray(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            k++;

    string[] newArray = new string[k];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

string[] array = { "Век", "живи", "-", "век", "учись" };
PrintArray(SortArray(array));
