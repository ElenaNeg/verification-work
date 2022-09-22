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
