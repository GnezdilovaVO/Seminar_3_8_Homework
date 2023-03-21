public static class Library
{
    public static void PrintArray(int[,] collection)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                Console.Write(" " + collection[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
    public static void FillArray(int[,] array)
    {
        int number = 1;
        int lengthArray = array.GetLength(1) - 1;
        int heigthArray = array.GetLength(0) - 1;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, j] = number;
            number = number + 1;
        }
        for (int k = 1; k < array.GetLength(0); k++)
        {
            array[k, heigthArray] = number;
            number = number + 1;
        }
        for (int m = lengthArray - 1; m >= 0; m--)
        {
            array[lengthArray, m] = number;
            number = number + 1;
        }
        for (int i = heigthArray - 1; i >= 1; i--)
        {
            array[i, 0] = number;
            number = number + 1;
        }
        for (int i = 1; i < lengthArray; i++)
        {
            array[1, i] = number;
            number = number + 1;
        }
        for (int i = lengthArray - 1; i > 0; i--)
        {
            array[2, i] = number;
            number = number + 1;
        }
    }
}