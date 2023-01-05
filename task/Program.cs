// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] array1 = new string[8] {"yesterday", "all", "my", "troubles", "seemed", "so", "far", "away"};
string[] array2 = new string[array1.Length];

void CreateChangeArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

CreateChangeArray(array1, array2);
PrintArray(array2);
