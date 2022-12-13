void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter the number of the array {i}");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void NewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
        Console.Write($"{array[i]} ");
        }
    }
    Console.Write("]");
}