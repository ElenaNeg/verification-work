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

Console.WriteLine("Input the length of the array: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);