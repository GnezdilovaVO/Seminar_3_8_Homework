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
                collection[i, j] = new Random().Next(0,50);
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
    public static int[] GetSumLine(int[,] array)
    {
        int n = array.GetLength(0);
        int[] arraySum = new int[n];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arraySum[i] = arraySum[i] + array[i, j];
            }
        }
        return arraySum;
    }
    public static string PrintSumLine(int[] array)
    {
        string elArray = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            elArray = elArray + array[i] + " ";
        }
        return elArray;
    }
    public static void GetMinLine(int[] array)
    {
        int minSum = array[0];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minSum)
            {
                minSum = array[i];
                count = i+1;
            }

        }
        Console.WriteLine(count + " строка");
    }
}