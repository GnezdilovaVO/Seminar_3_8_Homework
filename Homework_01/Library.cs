public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FillArray(int[,] collection)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                collection[i, j] = new Random().Next(0, 10);
            }
        }
    }
    public static void PrintArray(int[,] collection)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                Console.Write(collection[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void StreamLineArray(int[,] array)
    {
        int max = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, j] > array[i,k])
                    {
                        max = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = max;
                    }
                }

            }
        }

    }
}