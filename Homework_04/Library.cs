public static class Library
{
    public static void FillArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = new Random().Next(10, 99);
                }
            }
        }
    }
    public static void PrintArray(int[,,] array)
    {
        string position = String.Empty;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    position = position + ("(" + i + ", " + j + ", " + k + ")");
                    Console.Write(array[i, j, k] + position + " ");
                    position = String.Empty;
                }
                Console.WriteLine();
            }
        }
    }
}