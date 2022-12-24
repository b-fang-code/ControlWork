string[] sourceArray = new string[] { "Hello", "77", "Peace", "Cat", "=)" };
string[] resultArray = new string[sourceArray.Length];
Console.WriteLine("Исходный массив: ");
PrintArray(sourceArray);
SortArray(sourceArray,resultArray);
Console.WriteLine("Результат: ");
PrintArray(resultArray);


//////////////  Method ////////////////////
void SortArray(string[] firstArray, string[] secondArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
}


//////////////  Method ////////////////////
void PrintArray (string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}