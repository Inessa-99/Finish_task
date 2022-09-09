string[] array = new string[4] { "1234", "1567", "-2", "computer science"};
string[] arrayLess3 = new string[array.Length]; 

CreateNewArrayLess3(array, arrayLess3);
PrintArray(arrayLess3);

void CreateNewArrayLess3(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[n] = array1[i];
            n++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}