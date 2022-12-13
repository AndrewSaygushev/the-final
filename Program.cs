void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter the number of the array {i}");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}
