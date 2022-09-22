string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Input {i + 1} an array element: ");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}
void ThreeSymbolsArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int len = 3;
        if (array[i].Length <= len)
            Console.Write(array[i] + " ");
    }
}


Console.WriteLine("Input the length of the array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);

Console.Write("Array of three symbols:");
ThreeSymbolsArray(myArray);

Console.WriteLine();