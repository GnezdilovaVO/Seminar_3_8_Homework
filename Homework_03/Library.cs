public static class Library
{
    public static void FillArray(int[,] collection)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                collection[i, j] = new Random().Next(0, 9);
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
    public static int[,] GetMultiplication(int[,] array1, int[,] array2)
    {
        int[,] multi = new int[3, 3];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    multi[i, j] = multi[i, j] + array1[i, k] * array2[k, j];
                }
            }
        }
        return multi;
    }
}